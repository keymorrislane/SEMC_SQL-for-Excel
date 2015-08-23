using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Xml;

namespace ConnectDatabase
{
    public partial class SEMC_SQL_For_Excel
    {
        private void SEMC_SQL_For_Excel_Load(object sender, RibbonUIEventArgs e)
        {

        }
        private void Connect_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void QuickConnect_ItemsLoading(object sender, RibbonControlEventArgs e)
        {
            XmlDocument dbInfo = new XmlDocument();
            dbInfo.Load("C:\\Users\\liaoq\\Documents\\SEMC SQL Tools\\QuickConnect.xml");
            XmlNode root = dbInfo.SelectSingleNode("QuickConnect");
            XmlNodeList nodes = root.ChildNodes;
            int DBCount = nodes.Count;
            for(int i = 1; i <= DBCount; i++)
            {
                RibbonSplitButton newDB = new RibbonSplitButton();

                QuickConnect.Items.Add(RibbonSplitButton)
            }
        }
    }
}
