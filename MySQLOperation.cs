using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Web;
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
            if (!System.IO.File.Exists(xmlPath))
            {
                try
                {
                    System.IO.File.Create(xmlPath);
                    System.Windows.Forms.MessageBox.Show("配置文件已创建于"+xmlPath);
                    dbInfo.Load(xmlPath);
                    dbInfo.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>" +
                                   "\n<!DOCTYPE DBInfo[\n<!ELEMENT DBInfo ANY>\n<!ELEMENT DB ANY>" +
                                   "\n<!ELEMENT Address ANY>\n<!ELEMENT Account ANY>" +
                                   "\n<!ELEMENT PWD ANY>\n<!ELEMENT Port ANY>" +
                                   "\n<!ELEMENT DefaultSchema ANY>" +
                                   "\n<!ATTLIST DB HostName ID #REQUIRED>\n]>");
                }
                catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("创建配置文件失败。");
                    return false;
                }
            }
            XmlElement userRecord = dbInfo.GetElementById(hostName);
            if (userRecord != null)
            {
                userRecord.RemoveAll();
            }
            XmlElement root;
            this.AppendNode(dbInfo, dbInfo.DocumentElement, "DB HostName=" + hostName, "");
            root = dbInfo.GetElementById(hostName);
            this.AppendNode(dbInfo, root, "Address", hostAddress);
            this.AppendNode(dbInfo, root, "Account", userName);
            this.AppendNode(dbInfo, root, "PWD", password);
            this.AppendNode(dbInfo, root, "port", port);
            this.AppendNode(dbInfo, root, "DefaultSchema", defaultSchema);
            dbInfo.Save(xmlPath);
            return true;
        }

        private void AppendNode(XmlDocument dbInfo, XmlElement root,
                                string newElementString, string newAttributeString)
        {
            XmlElement newElement;
            XmlAttribute newAttribute;
            newElement = dbInfo.CreateElement(newElementString);
            newAttribute = dbInfo.CreateAttribute(newAttributeString);
            newElement.SetAttributeNode(newAttribute);
            root.AppendChild(newElement);
        }

        public bool MakeConnection(string hostName, string hostAddress,
                              string userName, string password,
                              string port, string defaultSchema)
        {
            string connectStr = "server=" + hostAddress + ";User Id=" +
                                userName + ";password=" + password + 
                                "DataBase=" + defaultSchema;
            try
            {
                MySqlConnection thisConnection = new MySqlConnection(connectStr);
                thisConnection.Open();
                this.connectStatus = true;
                return true;
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.connectStatus = false;
                return false;
            }
        }
    }
}
