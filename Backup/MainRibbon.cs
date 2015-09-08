using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using MySql.Data.MySqlClient;

namespace SSEBasicVersion
{
    public partial class MainRibbon
    {
        public static MySqlConnection connectionHandle = new MySqlConnection();
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Import_Click(object sender, RibbonControlEventArgs e)
        {
            ConnectMsg connectMBox = new ConnectMsg();
            connectMBox.Show();
            string connectString = "server=172.16.20.230;User Id=root;" +
                "password=123;DataBase=hbibmsdb";
            try
            {
                //MainRibbon.connectionHandle = new MySqlConnection(connectString);
                //connectionHandle.Open();
                //connectMBox.Close();
                Settings settings = new Settings();
                settings.Show();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "连接失败，请检查服务器或网络是否正常。");
            }
        }
    }
}
