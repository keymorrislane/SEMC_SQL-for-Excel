using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSEBasicVersion
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            string today = System.DateTime.Today.ToString("yyyy_MM_dd");
            BeginYear.Maximum = int.Parse(today.Split('_')[0]);
            EndYear.Maximum = BeginYear.Maximum;
            BeginYear.Value = int.Parse(today.Split('_')[0]);
            BeginMonth.Value = int.Parse(today.Split('_')[1]);
            BeginDay.Value = int.Parse(today.Split('_')[2]);
            EndYear.Value = BeginYear.Value;
            EndMonth.Value = BeginMonth.Value;
            EndDay.Value = BeginDay.Value;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EndYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
