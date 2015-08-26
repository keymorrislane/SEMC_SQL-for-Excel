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
        private ArrayList includeRow{ get; set;}
        private ArrayList includeCol{ get; set;}
        private ArrayList excludeRow{ get; set;}
        private ArrayList excludeCol{ get; set;}
        private long minRow { get; set; }
        private long maxRow { get; set; }
        private long minCol { get; set; }
        private long maxCol { get; set; }
        private string rowLineNumberFilterStatus { get; set; }
        private string colLineNumberFilterStatus { get; set; }
        private string tbName { get; set; }
        private string scName { get; set; }

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
            MaxRow.Value = maxRow;
            MaxCol.Value = maxCol;
            MaxRow.Maximum = maxRow;
            MaxCol.Maximum = maxCol;
            MySQLOperation mysqlObj = new MySQLOperation();
            DataTable columnNames = mysqlObj.GetColumnNames(
                ConnectionStatus.thisConnection, tableName);
            keyCol.Items.Clear();
            for (int i = 0; i < columnNames.Rows.Count; i++)
            {
                keyCol.Items.Add(columnNames.Rows[i].ItemArray[0]);
                ColExc.Items.Add(columnNames.Rows[i].ItemArray[0]);
            }
        }

        private void AdvancedExport_OK(object sender, EventArgs e)
        {
            GetCheckBoxValue();
        }

        private void GetCheckBoxValue()
        {
            if (RowIncCheckBox.Checked)
            {
                rowLineNumberFilterStatus = "inc";
                minRow = (int)MinRow.Value;
                maxRow = (int)MaxRow.Value;
            }
            else if (RowExcCheckBox.Checked)
            {
                rowLineNumberFilterStatus = "exc";
                minRow = (int)MinRow.Value;
                maxRow = (int)MaxRow.Value;
            }
            if (ColIncCheckBox.Checked)
            {
                colLineNumberFilterStatus = "inc";
                minCol = (int)MinCol.Value;
                maxCol = (int)MaxCol.Value;
            }
            else if (ColExcCheckBox.Checked)
            {
                colLineNumberFilterStatus = "exc";
                minCol = (int)MinCol.Value;
                maxCol = (int)MaxCol.Value;
            }
        }

        private ArrayList TextProcessing(string text)
        {
            if(text == null)
            {
                return null;
            }
            ArrayList result = new ArrayList();
            text.Replace("，", ",");
            foreach(string temp in text.Split(','))
            {
                result.Add(temp);
            }
            return result;
        }

        private void AdvancedExport_Cancel(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void RowInc_CheckedChanged(object sender, EventArgs e)
        {
            if (RowIncCheckBox.Checked && RowExcCheckBox.Checked)
            {
                RowExcCheckBox.Checked = false;
            }
        }

        private void RowExc_CheckedChanged(object sender, EventArgs e)
        {
            if (RowExcCheckBox.Checked && RowIncCheckBox.Checked)
            {
                RowIncCheckBox.Checked = false;
            }
        }

        private void ColInc_CheckedChanged(object sender, EventArgs e)
        {
            if (ColIncCheckBox.Checked && ColExcCheckBox.Checked)
            {
                ColExcCheckBox.Checked = false;
            }
        }

        private void ColExc_CheckedChanged(object sender, EventArgs e)
        {
            if (ColExcCheckBox.Checked && ColIncCheckBox.Checked)
            {
                ColIncCheckBox.Checked = false;
            }
        }

        private void RowFilter_Enter(object sender, EventArgs e)
        {

        }

        private void ColAdd_Click(object sender, EventArgs e)
        {
            ItemMove(ColInc, ColExc, ColIncSearch, ColExcSearch);
            ColExcSearch.AutoCompleteCustomSource = BuildStringCollection(ColExc.Items);
            ColIncSearch.AutoCompleteCustomSource = BuildStringCollection(ColInc.Items);
        }

        private void RowAdd_Click(object sender, EventArgs e)
        {
            ItemMove(RowInc, RowExc, RowIncSearch, RowExcSearch);
            RowExcSearch.AutoCompleteCustomSource = BuildStringCollection(RowExc.Items);
            RowIncSearch.AutoCompleteCustomSource = BuildStringCollection(RowInc.Items);
        }

        private void ColRemove_Click(object sender, EventArgs e)
        {
            ItemMove(ColExc, ColInc, ColExcSearch, ColIncSearch);
            ColExcSearch.AutoCompleteCustomSource = BuildStringCollection(ColExc.Items);
            ColIncSearch.AutoCompleteCustomSource = BuildStringCollection(ColInc.Items);
        }

        private void RowRemove_Click(object sender, EventArgs e)
        {
            ItemMove(RowExc, RowInc, RowExcSearch, RowIncSearch);
            RowExcSearch.AutoCompleteCustomSource = BuildStringCollection(RowExc.Items);
            RowIncSearch.AutoCompleteCustomSource = BuildStringCollection(RowInc.Items);
        }

        private void ItemMove(ListBox Add, ListBox Remove, TextBox AddSearch, TextBox RemoveSearch)
            //将元素在左右框移动，并重置搜索栏的自动完成。
        {
            int count = Remove.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                Add.Items.Add(Remove.SelectedItems[0].ToString());
                Remove.Items.Remove(Remove.SelectedItems[0]);
            }
            AddSearch.AutoCompleteCustomSource = BuildStringCollection(Add.Items);
            RemoveSearch.AutoCompleteCustomSource = BuildStringCollection(Remove.Items);
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
            MySqlDataAdapter data = new MySqlDataAdapter(
                "select " + keyCol.Text + " from " + tbName,
                ConnectionStatus.thisConnection);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            for(int row=0; row < dataTable.Rows.Count; row++)
            {
                if (!RowExc.Items.Contains(dataTable.Rows[row].ItemArray[0]))
                {
                    RowExc.Items.Add(dataTable.Rows[row].ItemArray[0]);
                }
            }
        }

        private void Search_Changed(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
        }

    }
}
