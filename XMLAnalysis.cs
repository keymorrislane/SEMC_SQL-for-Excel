using System;
using System.Text;
using System.Xml;

namespace ConnectDatabase
{
    class XMLAnalysis
    {
        public static void CreateXML(string xmlPath)
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
                xmlWriter.WriteDocType("DBInfo", null, null, 
                    "<!ATTLIST DB HostName ID #REQUIRED>");
                xmlWriter.WriteElementString("DBInfo", "\n");
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
        }

        public static void AppendNode(XmlElement root, XmlDocument dbInfo,
                                string newElementString, string newText)
        {
            XmlElement newElement = dbInfo.CreateElement(newElementString);
            newElement.InnerText = newText;
            root.AppendChild(newElement);
        }
    }
}
