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
                    ConnectionManager.ActiveForm.Hide();
                    MessageBox.Show("连接成功！");
                    newOperation.NewConnection(hostName, hostAddress, userName, 
                        password, port, defaultSchema);
                }
                else
                {
                    MessageBox.Show("连接失败，请检查填写是否有误！");
                }
            }
        }
    }
}
