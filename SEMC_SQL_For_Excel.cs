using System;
using Microsoft.Office.Tools.Ribbon;
using System.Xml;

namespace ConnectDatabase
{
    public partial class SEMC_SQL_For_Excel
    {
        private void SEMC_SQL_For_Excel_Load(object sender, RibbonUIEventArgs e)
        {
            ExportFromSQL.Enabled = false;
            ImportInDB.Enabled = false;
        }

        private void Connect_Click(object sender, RibbonControlEventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            connectionManager.Show();
            if (ConnectionStatus.alive)
            {
                Disconnect.Enabled = true;
            }
        }

        public Microsoft.Office.Tools.Ribbon.RibbonButton QuickConnectItem;
        private void QuickConnectMenu_ItemsLoading(
            object sender, RibbonControlEventArgs e)
        {
            QuickConnectItem = null;
            XmlDocument dbInfo = new XmlDocument();
            ConnectionStatus.xmlPath = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal) + "\\SEMC_SQL_For_Excel.xml";
            if (System.IO.File.Exists(ConnectionStatus.xmlPath))
            {
                dbInfo.Load(ConnectionStatus.xmlPath);
                XmlNodeList recNode = dbInfo.SelectNodes("//DBInfo/DB");
                //This is for each text in every child. That's we can easily find any text.
                if(QuickConnect.Items.Count != 0)
                {
                    QuickConnect.Items.Clear();
                }

                foreach (XmlNode node in recNode)
                {
                    string temp;
                    temp = node.Attributes[0].Value.ToString();
                    this.QuickConnectItem = this.Factory.CreateRibbonButton();
                    this.QuickConnectItem.Label = temp;
                    this.QuickConnectItem.Name = temp;
                    this.QuickConnectItem.Click += 
                        new RibbonControlEventHandler(QuickConnectItems_Click);
                    this.QuickConnectItem.Visible = true;
                    this.QuickConnectItem.ShowImage = false;
                    QuickConnect.Items.Add(this.QuickConnectItem);
                    this.QuickConnectItem.Dispose();
                }
                dbInfo = null;
                ConnectionStatus.xmlPath = null;
                recNode = null;
            }
            QuickConnectItem.Dispose();
        }

        private void QuickConnectItems_Click(object sender, RibbonControlEventArgs e)
        {
            string hostName = e.Control.Id;
            string address, port, user, password, defaultSchema;
            ConnectionStatus.xmlPath = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal) + "\\SEMC_SQL_For_Excel.xml";
            XmlDocument dbInfo = new XmlDocument();
            dbInfo.Load(ConnectionStatus.xmlPath);
            XmlNode root = dbInfo.DocumentElement;
            address = root.SelectSingleNode("//DBInfo/DB[@HostName='" + 
                hostName + "']/Address").InnerText;
            port = root.SelectSingleNode("//DBInfo/DB[@HostName='" + 
                hostName + "']/Port").InnerText;
            user = root.SelectSingleNode("//DBInfo/DB[@HostName='" + 
                hostName + "']/Account").InnerText;
            password = root.SelectSingleNode("//DBInfo/DB[@HostName='" + 
                hostName + "']/PWD").InnerText;
            defaultSchema = root.SelectSingleNode("//DBInfo/DB[@HostName='" + 
                hostName + "']/DefaultSchema").InnerText;
            password = AESModel.AESHelper.AESDecryptWithVector(
                password, "SEMCWangsese8586", "SEMCWangVector00");
            MySQLOperation mySQLOperation = new MySQLOperation();
            if(mySQLOperation.MakeConnection(
                hostName, address, user, password, port, defaultSchema))
            {
                System.Windows.Forms.MessageBox.Show("连接成功");
                ConnectionStatus.alive = true;
                ConnectionStatus.connectionName = hostName;
                Globals.Ribbons.Ribbon1.Disconnect.Enabled = true;
                Globals.Ribbons.Ribbon1.ExportFromSQL.Enabled = true;
                Globals.Ribbons.Ribbon1.ImportInDB.Enabled = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "连接失败，请检查服务器或网络是否正常！");
            }
        }

        private void ExportFromSQL_Click(
            object sender, RibbonControlEventArgs e)
        {
            ExportData exportData = new ExportData();
            exportData.Show();
        }

        private void Disconnect_Click(
            object sender, RibbonControlEventArgs e)
        {
            ConnectionStatus.thisConnection.Close();
            ConnectionStatus.thisConnection.Dispose();
            System.Windows.Forms.MessageBox.Show("连接已断开。");
            Globals.Ribbons.Ribbon1.Disconnect.Enabled = false;
            Globals.Ribbons.Ribbon1.ExportFromSQL.Enabled = false;
            Globals.Ribbons.Ribbon1.ImportInDB.Enabled = false;
            ConnectionStatus.alive = false;
            ConnectionStatus.connectionName = null;
        }

    }
}
