using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnectDatabase
{
    public partial class ExportData : Form
    {
        public Button chooseItem;
        public ExportData()
        {
            InitializeComponent();
            MySQLOperation thisOperation = new MySQLOperation();
            DataTable schemaNames = thisOperation.GetSchemaNames(
                ConnectionStatus.thisConnection);
            for (int i = 0; i < schemaNames.Rows.Count; i++)
            {
                DataRow row = schemaNames.Rows[i];
                SchemaComboBox.Items.Add(row.ItemArray[0]);
            }
        }

        private void AdvancedExport_Click(object sender, EventArgs e)
        {
            AdvancedExport advancedExport = new AdvancedExport(
                TableComboBox.Text, SchemaComboBox.Text);
            advancedExport.Show();
        }

        private void Schema_Changed(object sender, EventArgs e)
        {
            TableComboBox.Items.Clear();
            MySQLOperation thisOperation = new MySQLOperation();
            DataTable tableNames = thisOperation.GetTableNames(
                ConnectionStatus.thisConnection, SchemaComboBox.Text);
            for (int i = 0; i < tableNames.Rows.Count; i++)
            {
                DataRow row = tableNames.Rows[i];
                TableComboBox.Items.Add(row.ItemArray[0]);
            }
        }

        private void Table_Changed(object sender, EventArgs e)
        {

        }
    }
}
