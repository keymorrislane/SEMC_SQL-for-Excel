using MySql.Data.MySqlClient;
using System;
using System.Text;
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
            string myFolderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string xmlPath = myFolderPath + "\\SEMC_SQL_For_Excel.xml";
            XmlDocument dbInfo = new XmlDocument();
            XmlElement root, newElement;
            XmlAttribute newAttribute;
            if (System.IO.File.Exists(xmlPath))
            {
                dbInfo.Load(xmlPath);
                if(dbInfo.DocumentElement == null)
                {
                    dbInfo = null;
                    System.IO.File.Delete(xmlPath);
                    CreateXML(xmlPath);
                }
            }
            else
            {
                CreateXML(xmlPath);
                dbInfo.Load(xmlPath);
            }
            XmlElement userRecord = dbInfo.GetElementById(hostName);
            if (userRecord != null)
            {
                userRecord.RemoveAll();
            }
            root = dbInfo.DocumentElement;
            newAttribute = dbInfo.CreateAttribute("HostName");
            newElement = dbInfo.CreateElement("DB");
            newElement.SetAttribute("HostName", hostName);
            root.AppendChild(newElement);
            root = newElement;
            AppendNode(root, dbInfo, "Address", hostAddress);
            AppendNode(root, dbInfo, "Account", userName);
            AppendNode(root, dbInfo, "PWD", password);
            AppendNode(root, dbInfo, "Port", port);
            AppendNode(root, dbInfo, "DefaultSchema", defaultSchema);
            try
            {
                dbInfo.Save(xmlPath);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void CreateXML(string xmlPath)
        {
            try
            {
                System.IO.FileStream xmlFile = System.IO.File.Create(xmlPath);
                System.Windows.Forms.MessageBox.Show("配置文件已创建于" + xmlPath);
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = new UTF8Encoding(false);
            settings.NewLineChars = Environment.NewLine;
            using (XmlWriter xmlWriter = XmlWriter.Create(xmlPath, settings))
            {
                xmlWriter.WriteStartDocument(false);
                xmlWriter.WriteDocType("DBInfo", null, null, "<!ATTLIST DB HostName ID #REQUIRED>");
                xmlWriter.WriteElementString("DBInfo", "\n");
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
        }

        private void AppendNode(XmlElement root, XmlDocument dbInfo,
                                string newElementString, string newText)
        {
            XmlElement newElement = dbInfo.CreateElement(newElementString);
            newElement.InnerText = newText;
            root.AppendChild(newElement);
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
                MySqlConnection thisConnection = new MySqlConnection(connectStr);
                thisConnection.Open();
                this.connectStatus = true;
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.connectStatus = false;
                return false;
            }
        }
        static void Main(string[] args)
        {
            MySQLOperation obj = new MySQLOperation();
            obj.NewConnection("test","localhost","root","abcd1234","3206","test");
            return;
        }
    }
}
