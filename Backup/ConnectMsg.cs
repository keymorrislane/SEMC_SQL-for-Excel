﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSEBasicVersion
{
    public partial class ConnectMsg : Form
    {
        public ConnectMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainRibbon.connectionHandle.Close();
            MainRibbon.connectionHandle.Dispose();
            this.Close();
        }
    }
}