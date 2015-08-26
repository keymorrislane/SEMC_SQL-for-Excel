using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Xml;

namespace ConnectDatabase
{
    public class MySQLOperation
    //An Encapsulation of some operations in MySQL, mainly handling with connection and authentication.
    {
        public bool connectStatus
        {
            get; set;
        }
        public MySQLOperation()
        {

        }
        public bool NewConnection(string hostName, string hostAddress,
                              string userName, string password,
                              string port, string defaultSchema)
        //Create a new Connection in an xml file.
        {
            string myFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ConnectionStatus.xmlPath = myFolderPath + "\\SEMC_SQL_For_Excel.xml";
            XmlDocument dbInfo = new XmlDocument();
            XmlElement root, newElement;
            XmlAttribute newAttribute;
            if (System.IO.File.Exists(ConnectionStatus.xmlPath))
            {
                dbInfo.Load(ConnectionStatus.xmlPath);
                if(dbInfo.DocumentElement == null)
                {
                    dbInfo = null;
                    System.IO.File.Delete(ConnectionStatus.xmlPath);
                    XMLAnalysis.CreateXML(ConnectionStatus.xmlPath);
                }
            }
            else
            {
                XMLAnalysis.CreateXML(ConnectionStatus.xmlPath);
                dbInfo.Load(ConnectionStatus.xmlPath);
            }
            XmlNode userRecord = null;
            userRecord = dbInfo.SelectSingleNode("//DBInfo/DB[@HostName='" + 
                hostName + "']");
            if (userRecord != null)
            {
                userRecord.RemoveAll();
                dbInfo.SelectSingleNode("//DBInfo").RemoveChild(userRecord);
            }
            root = dbInfo.DocumentElement;
            newAttribute = dbInfo.CreateAttribute("HostName");
            newElement = dbInfo.CreateElement("DB");
            newElement.SetAttribute("HostName", hostName);
            root.AppendChild(newElement);
            root = newElement;
            XMLAnalysis.AppendNode(root, dbInfo, "Address", hostAddress);
            XMLAnalysis.AppendNode(root, dbInfo, "Account", userName);
            XMLAnalysis.AppendNode(root, dbInfo, "PWD", password);
            XMLAnalysis.AppendNode(root, dbInfo, "Port", port);
            XMLAnalysis.AppendNode(root, dbInfo, "DefaultSchema", defaultSchema);
            try
            {
                dbInfo.Save(ConnectionStatus.xmlPath);
                dbInfo = null; 
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool MakeConnection(string hostName, string hostAddress,
                              string userName, string password,
                              string port, string defaultSchema)
        {
            string connectStr = "server=" + hostAddress + ";User Id=" +
                                userName + ";password=" + password +
                                ";DataBase=" + defaultSchema;
            try
            {
                ConnectionStatus.thisConnection = new MySqlConnection(connectStr);
                ConnectionStatus.thisConnection.Open();
                connectStatus = true;
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.connectStatus = false;
                return false;
            }
        }

        private DataTable FillTable(MySqlDataAdapter data)
        {
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetSchemaNames(MySqlConnection connectionObj)
            //取得库名
        {
            string cmdText = "show databases";
            MySqlDataAdapter data = new MySqlDataAdapter(cmdText, connectionObj);
            return FillTable(data);
        }

        public DataTable GetTableNames(MySqlConnection connectionObj, string schema)
            //取得表名
        {
            MySqlCommand cmd = new MySqlCommand("use " + schema, ConnectionStatus.thisConnection);
            int val = cmd.ExecuteNonQuery();
            cmd.Dispose();
            string cmdText = "show tables;";
            MySqlDataAdapter data = new MySqlDataAdapter(cmdText, connectionObj);
            return FillTable(data);
        }

        public DataTable GetColumnNames(MySqlConnection connectionObj, 
            string tableName)
            //取得列名
        {
            MySqlDataAdapter data = new MySqlDataAdapter("describe " + tableName, connectionObj);
            return FillTable(data);
        }
    }
}
