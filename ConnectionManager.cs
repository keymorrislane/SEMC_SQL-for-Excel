using System;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

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

        }

        private void ConnectionManagerButtonOK_Click(object sender, EventArgs e)
        {
            MySQLOperation newOperation = new MySQLOperation();
            string hostName, hostAddress, port, userName, password, defaultSchema = "";
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
                    MessageBox.Show("连接失败，请检查填写是否有误或服务器是否正常！");
                }
            }
            return;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
