using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ConnectDatabase
{
    public class ConnectionStatus
    {
        public static bool alive
        {
            get; set;
        }
        public static string connectionName
        {
            get; set;
        }
        private static bool _alive = false;
        private static string _connectName = "";
    }
    public partial class SEMC_DB_Tools
    {
        private void SEMC_DB_Tools_Startup(object sender, System.EventArgs e)
        {
        }

        private void SEMC_DB_Tools_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(SEMC_DB_Tools_Startup);
            this.Shutdown += new System.EventHandler(SEMC_DB_Tools_Shutdown);
        }
        
        #endregion
    }
}
