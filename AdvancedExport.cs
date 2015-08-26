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
        private int minRow { get; set; }
        private int maxRow { get; set; }
        private int minCol { get; set; }
        private int maxCol { get; set; }
        private string rowLineNumberFilterStatus { get; set; }
        private string colLineNumberFilterStatus { get; set; }

        public AdvancedExport()
        {
            InitializeComponent();
            minRow = 1;
            minCol = 1;
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
