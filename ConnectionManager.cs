using System;
using System.Windows.Forms;
using System.Xml;

namespace ConnectDatabase
{
    public partial class ConnectionManager : Form
    {
        public ConnectionManager()
        {
            InitializeComponent();
        }

        private void ConnectionManager_Load(object sender, EventArgs e)
        {
            XmlDocument dbInfo = new XmlDocument();
            ConnectionStatus.xmlPath = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal) + "\\SEMC_SQL_For_Excel.xml";
            if (System.IO.File.Exists(ConnectionStatus.xmlPath))
            {
                dbInfo.Load(ConnectionStatus.xmlPath);
                XmlNodeList recNode = dbInfo.GetElementsByTagName("DB");
                XmlNodeList childList = null;
                //This is for each text in every child. That's we can easily find any text.
                foreach (XmlNode node in recNode)
                {
                    childList = node.ChildNodes;
                    HostNameComboBox.Items.Add(
                        node.Attributes.GetNamedItem("HostName").InnerText);
                }
            }
            dbInfo = null;
        }

        private void ConnectionManagerButtonOK_Click(object sender, EventArgs e)
        {
            MySQLOperation newOperation = new MySQLOperation();
            string hostName, hostAddress, port, userName, password, defaultSchema;
            hostName = HostNameComboBox.Text;
            hostAddress = HostAddressTextBox.Text;
            port = PortTextBox.Text;
            userName = UserNameTextBox.Text;
            password = PasswordTextBox.Text;
            defaultSchema = DefaultSchemaTextBox.Text;
            if (hostName != "" && hostAddress != "" &&port != "" && 
                userName != "" && password != "")
            {
                if (newOperation.MakeConnection(hostName, hostAddress, userName,
                    password,port,defaultSchema))
                {
                    ActiveForm.Close();
                    MessageBox.Show("连接成功！");
                    ConnectionStatus.alive = true;
                    ConnectionStatus.connectionName = hostName;
                    Globals.Ribbons.Ribbon1.Disconnect.Enabled = true;
                    password = AESModel.AESHelper.AESEncryptWithVector(password,
                        "SEMCWangsese8586", "SEMCWangVector00");
                    newOperation.NewConnection(hostName, hostAddress, userName, 
                        password, port, defaultSchema);
                }
                else
                {
                    MessageBox.Show("连接失败，请检查填写是否有误,网络状态或服务器是否正常！");
                }
            }
            return;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void HostName_Changed(object sender, EventArgs e)
        {

        }

        private void HostNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument dbInfo = new XmlDocument();
            string xmlPath, hostName;
            xmlPath = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal) + "\\SEMC_SQL_For_Excel.xml";
            if (System.IO.File.Exists(xmlPath))
            {
                dbInfo.Load(xmlPath);
            }
            hostName = HostNameComboBox.Text;
            XmlNode root = dbInfo.DocumentElement;
            root = dbInfo.SelectSingleNode("DBInfo/DB[@HostName='" + hostName + "']");
            HostAddressTextBox.Text = root.SelectSingleNode("Address").InnerText;
            UserNameTextBox.Text = root.SelectSingleNode("Account").InnerText;
            PasswordTextBox.Text = AESModel.AESHelper.AESDecryptWithVector(
                root.SelectSingleNode("PWD").InnerText, 
                "SEMCWangsese8586", "SEMCWangVector00"); 
            PortTextBox.Text = root.SelectSingleNode("Port").InnerText;
            DefaultSchemaTextBox.Text = root.SelectSingleNode("DefaultSchema").InnerText;
        }
    }
}
