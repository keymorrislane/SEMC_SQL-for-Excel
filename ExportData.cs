using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;


namespace ConnectDatabase
{
    public partial class ExportData : Form
    {
        public System.Windows.Forms.Button chooseItem;
        public static ArrayList colExport = new ArrayList();
        public static ArrayList rowExport = new ArrayList();
        public ExportData()
        {
            InitializeComponent();
            MySQLOperation thisOperation = new MySQLOperation();
            System.Data.DataTable schemaNames = thisOperation.GetSchemaNames(
                ConnectionStatus.thisConnection);
            for (int i = 0; i < schemaNames.Rows.Count; i++)
            {
                DataRow row = schemaNames.Rows[i];
                SchemaComboBox.Items.Add(row.ItemArray[0]);
            }
        }

        private void AdvancedExport_Click(object sender, EventArgs e)
        {
            if(SchemaComboBox.Text == "" || SchemaComboBox.Text == null)
            {
                MessageBox.Show("请选择数据库！");
                return;
            }
            else if(TableComboBox.Text == null || TableComboBox.Text == "")
            {
                MessageBox.Show("请选择数据表！");
                return;
            }
            else
            {
                AdvancedExport advancedExport = new AdvancedExport(
                TableComboBox.Text, SchemaComboBox.Text);
                advancedExport.Show();
                return;
            }
        }

        private void Schema_Changed(object sender, EventArgs e)
        {
            TableComboBox.Items.Clear();
            MySQLOperation thisOperation = new MySQLOperation();
            System.Data.DataTable tableNames = thisOperation.GetTableNames(
                ConnectionStatus.thisConnection, SchemaComboBox.Text);
            for (int i = 0; i < tableNames.Rows.Count; i++)
            {
                DataRow row = tableNames.Rows[i];
                TableComboBox.Items.Add(row.ItemArray[0]);
            }
        }

        private void Export_Confirm_Click(object sender, EventArgs e)
        {
            string cmd;
            cmd = "";
            foreach(var item in AdvancedExport.colIncList)
            {
                cmd += item.ToString() + ",";
            }
            cmd = cmd.Substring(0,cmd.Length - 1);
            cmd = "select " + cmd + " from " + TableComboBox.Text + " where ";
            foreach(var item in AdvancedExport.rowIncList)
            {
                string col = item.ToString().Split('@')[0];
                string key = item.ToString().Split('@')[1];
                if (!cmd.Substring(cmd.IndexOf("where")).Contains(col))
                {
                    cmd += col + " in () and ";
                }
                int insertPoint = cmd.IndexOf(col,cmd.IndexOf("where")) + col.Length + 5;
                cmd = cmd.Insert(insertPoint, "'" + key + "',");
            }
            cmd = cmd.Substring(0, cmd.Length - 5) + ";";
            while (cmd.Contains(",)"))
            {
                cmd = cmd.Remove(cmd.IndexOf(",)"),1);
            }
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd, ConnectionStatus.thisConnection);
            DataSet dataSet = new DataSet();
            myAdapter.Fill(dataSet);
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet activeWorksheet =
                (Worksheet)Globals.SEMC_DB_Tools.Application.ActiveWorkbook.ActiveSheet;
            try
            {
                for (int col = 0; col < dataSet.Tables[0].Columns.Count; col++)
                {
                    activeWorksheet.Cells[1, col + 1].Value = dataSet.Tables[0].Columns[col].ToString();
                }
                for (int row = 0; row < dataSet.Tables[0].Rows.Count; row++)
                {
                    for(int col = 0; col < dataSet.Tables[0].Columns.Count; col++)
                    {
                        activeWorksheet.Cells[row + 2, col + 1].Value = dataSet.Tables[0].Rows[row].ItemArray[col].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("导出失败！");
            }
            ActiveForm.Close();
        }
    }
}
