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

        public AdvancedExport(string tableName, string schemaName)
        {
            InitializeComponent();
            InitializeBox(tableName, schemaName);
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
            }
        }

        private void AdvancedExport_OK(object sender, EventArgs e)
        {
            includeRow = TextProcessing(RowIncludeText.Text);
            includeCol = TextProcessing(ColIncludeText.Text);
            excludeRow = TextProcessing(RowExcludeText.Text);
            excludeCol = TextProcessing(ColExcludeText.Text);
            if (RowIncCheckBox.Checked)
            {
                rowLineNumberFilterStatus = "inc";
                minRow = (int)MinRow.Value;
                maxRow = (int)MaxRow.Value;
            }
            else if(RowExcCheckBox.Checked){
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
    }
}
