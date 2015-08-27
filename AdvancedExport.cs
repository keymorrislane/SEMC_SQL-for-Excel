using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace ConnectDatabase
{
    
    public partial class AdvancedExport : Form
    {
        public static long minRow { get; set; }
        public static long maxRow { get; set; }
        public static long minCol { get; set; }
        public static long maxCol { get; set; }
        public static string rowLineNumberFilterStatus { get; set; }
        public static string colLineNumberFilterStatus { get; set; }
        private string tbName { get; set; }
        private string scName { get; set; }
        public static ArrayList colExcList = new ArrayList();
        public static ArrayList rowExcList = new ArrayList();
        public static ArrayList colIncList = new ArrayList();
        public static ArrayList rowIncList = new ArrayList();

        public AdvancedExport(string tableName, string schemaName)
        {
            InitializeComponent();
            InitializeBox(tableName, schemaName);
            ColExcSearch.AutoCompleteCustomSource = BuildStringCollection(ColExc.Items);
            tbName = tableName;
            scName = schemaName;
        }

        private AutoCompleteStringCollection BuildStringCollection(
            ListBox.ObjectCollection items)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var item in items)
            {
                collection.Add(item.ToString());
            }
            return collection;
        }

        private void InitializeBox(string tableName, string schemaName)
        {
            minRow = 1;
            minCol = 1;
            MySqlDataAdapter data = new MySqlDataAdapter(
                "select count(*) from " + tableName,
                ConnectionStatus.thisConnection);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            maxRow = (long)dataTable.Rows[0].ItemArray[0];
            data = new MySqlDataAdapter(
                "select count(*) from information_schema.columns where table_schema='" + 
                schemaName + "' and table_name='" + tableName + "'",
                ConnectionStatus.thisConnection);
            dataSet = new DataSet();
            data.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            maxCol = (long)dataTable.Rows[0].ItemArray[0];
            MySQLOperation mysqlObj = new MySQLOperation();
            DataTable columnNames = mysqlObj.GetColumnNames(
                ConnectionStatus.thisConnection, tableName);
            keyCol.Items.Clear();
            for (int i = 0; i < columnNames.Rows.Count; i++)
            {
                var item = columnNames.Rows[i].ItemArray[0];
                keyCol.Items.Add(item);
                colExcList.Add(item);
                ColExc.Items.Add(item);
                ExportData.colExport.Add(item);
            }
        }

        private void AdvancedExport_OK(object sender, EventArgs e)
        {
            ActiveForm.Close();
            return;
        }

       
        private void AdvancedExport_Cancel(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void RowFilter_Enter(object sender, EventArgs e)
        {

        }

        private void ColAdd_Click(object sender, EventArgs e)
        {
            ItemMove(ColInc, ColExc, ColIncSearch, ColExcSearch);
            colExcList.Clear();
            colIncList.Clear();
            foreach(var item in ColExc.Items)
            {
                colExcList.Add(item);
            }
            foreach(var item in ColInc.Items)
            {
                colIncList.Add(item);
            }
        }

        private void RowAdd_Click(object sender, EventArgs e)
        {
            string temp;
            rowExcList.Clear();
            rowIncList.Clear();
            int count = RowExc.SelectedItems.Count;
            for(int i = 0; i < count; i++)
            {
                temp = keyCol.Text + "@" + RowExc.SelectedItems[0].ToString();
                RowExc.Items.Remove(RowExc.SelectedItems[0]);
                RowInc.Items.Add(temp);
            }
            foreach(var item in RowExc.Items)
            {
                rowExcList.Add(item);
            }
            foreach(var item in RowInc.Items)
            {
                rowIncList.Add(item);
            }
        }

        private void ColRemove_Click(object sender, EventArgs e)
        {
            ItemMove(ColExc, ColInc, ColExcSearch, ColIncSearch);
            colExcList.Clear();
            colIncList.Clear();
            foreach (var item in ColExc.Items)
            {
                colExcList.Add(item);
            }
            foreach (var item in ColInc.Items)
            {
                colIncList.Add(item);
            }
        }

        private void RowRemove_Click(object sender, EventArgs e)
        {
            string temp;
            int count = RowInc.SelectedItems.Count;
            rowExcList.Clear();
            rowIncList.Clear();
            for (int i = 0; i < count; i++)
            {
                temp = RowInc.SelectedItems[0].ToString().Split('@')[0];
                if(temp == keyCol.Text)
                {
                    RowExc.Items.Add(RowInc.SelectedItems[0].ToString().Split('@')[1]);
                }
                RowInc.Items.Remove(RowInc.SelectedItems[0]);
            }
            foreach (var item in RowExc.Items)
            {
                rowExcList.Add(item);
            }
            foreach (var item in RowInc.Items)
            {
                rowIncList.Add(item);
            }
        }

        private void ItemMove(
            ListBox Add, ListBox Remove, TextBox AddSearch, TextBox RemoveSearch)
            //将元素在左右框移动，并重置搜索栏的自动完成。
        {
            int count = Remove.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                Add.Items.Add(Remove.SelectedItems[0].ToString());
                Remove.Items.Remove(Remove.SelectedItems[0]);
            }
            AddSearch.AutoCompleteCustomSource = 
                BuildStringCollection(Add.Items);
            RemoveSearch.AutoCompleteCustomSource = 
                BuildStringCollection(Remove.Items);
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(textBox.Text == "搜索")
            {
                textBox.Text = "";
            }
        }

        private void keyCol_Changed(object sender, EventArgs e)
        {
            RowExc.Items.Clear();
            if(keyCol.Text == "")
            {
                return;
            }
            MySqlDataAdapter data = new MySqlDataAdapter(
                "select " + keyCol.Text + " from " + tbName,
                ConnectionStatus.thisConnection);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            ArrayList rowIncNames = new ArrayList();
            foreach(var item in RowInc.Items)
            {
                rowIncNames.Add(item.ToString().Replace(keyCol.Text + "@", ""));
                //让“列名.关键字”的形式转换为“关键字”
            }
            for(int row=0; row < dataTable.Rows.Count; row++)
            {
                var item = dataTable.Rows[row].ItemArray[0];
                if (!RowExc.Items.Contains(item.ToString()) && !rowIncNames.Contains(item.ToString()))
                {
                    RowExc.Items.Add(item);
                    rowExcList.Add(item);
                }
            }
            rowExcList.Clear();
            foreach (var item in RowExc.Items)
            {
                rowExcList.Add(item);
            }
        }

        private void Search_Changed(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            ListBox listBox = new ListBox();
            ArrayList sourceList = new ArrayList();
            if(textBox.Name == "ColExcSearch")
            {
                listBox = ColExc;
                sourceList = colExcList;
            }
            else if(textBox.Name == "ColIncSearch")
            {
                listBox = ColInc;
                sourceList = colIncList;
            }
            else if(textBox.Name == "RowExcSearch")
            {
                listBox = RowExc;
                sourceList = rowExcList;
            }
            else
            {
                listBox = RowInc;
                sourceList = rowIncList;
            }
            listBox.Items.Clear();
            foreach(var item in sourceList)
            {
                listBox.Items.Add(item);
            }
            for (int i = listBox.Items.Count - 1; i >= 0; i--)
            {
                if (!listBox.Items[i].ToString().Contains(textBox.Text))
                {
                    listBox.Items.Remove(listBox.Items[i]);
                }
            }
        }
    }
}
