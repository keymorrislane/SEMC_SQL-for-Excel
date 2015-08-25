namespace ConnectDatabase
{
    partial class SEMC_SQL_For_Excel : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SEMC_SQL_For_Excel()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataBase = this.Factory.CreateRibbonTab();
            this.Connection = this.Factory.CreateRibbonGroup();
            this.QuickConnect = this.Factory.CreateRibbonMenu();
            this.Connect = this.Factory.CreateRibbonButton();
            this.Data = this.Factory.CreateRibbonGroup();
            this.ExportFromSQL = this.Factory.CreateRibbonButton();
            this.ImportInDB = this.Factory.CreateRibbonButton();
            this.Modify = this.Factory.CreateRibbonButton();
            this.Disconnect = this.Factory.CreateRibbonButton();
            this.DataBase.SuspendLayout();
            this.Connection.SuspendLayout();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBase
            // 
            this.DataBase.Groups.Add(this.Connection);
            this.DataBase.Groups.Add(this.Data);
            this.DataBase.Label = "SEMC_SQL";
            this.DataBase.Name = "DataBase";
            // 
            // Connection
            // 
            this.Connection.Items.Add(this.QuickConnect);
            this.Connection.Items.Add(this.Connect);
            this.Connection.Items.Add(this.Disconnect);
            this.Connection.Label = "连接操作";
            this.Connection.Name = "Connection";
            this.Connection.Position = this.Factory.RibbonPosition.BeforeOfficeId("Data");
            // 
            // QuickConnect
            // 
            this.QuickConnect.Label = "快速连接";
            this.QuickConnect.Name = "QuickConnect";
            this.QuickConnect.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.QuickConnect_ItemsLoading);
            // 
            // Connect
            // 
            this.Connect.Label = "新连接";
            this.Connect.Name = "Connect";
            this.Connect.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Connect_Click);
            // 
            // Data
            // 
            this.Data.Items.Add(this.ExportFromSQL);
            this.Data.Items.Add(this.ImportInDB);
            this.Data.Items.Add(this.Modify);
            this.Data.Label = "数据操作";
            this.Data.Name = "Data";
            // 
            // ExportFromSQL
            // 
            this.ExportFromSQL.Label = "从数据库导出";
            this.ExportFromSQL.Name = "ExportFromSQL";
            this.ExportFromSQL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ExportFromSQL_Click);
            // 
            // ImportInDB
            // 
            this.ImportInDB.Label = "导入数据库";
            this.ImportInDB.Name = "ImportInDB";
            // 
            // Modify
            // 
            this.Modify.Label = "修改数据库";
            this.Modify.Name = "Modify";
            // 
            // Disconnect
            // 
            this.Disconnect.Label = "断开连接";
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Enabled = false;
            this.Disconnect.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Disconnect_Click);
            // 
            // SEMC_SQL_For_Excel
            // 
            this.Name = "SEMC_SQL_For_Excel";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.DataBase);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SEMC_SQL_For_Excel_Load);
            this.DataBase.ResumeLayout(false);
            this.DataBase.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab DataBase;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Connection;
        public Microsoft.Office.Tools.Ribbon.RibbonButton Connect;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Data;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ExportFromSQL;
        public Microsoft.Office.Tools.Ribbon.RibbonButton ImportInDB;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Modify;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu QuickConnect;
        public Microsoft.Office.Tools.Ribbon.RibbonButton Disconnect;
    }

    partial class ThisRibbonCollection
    {
        internal SEMC_SQL_For_Excel Ribbon1
        {
            get { return this.GetRibbon<SEMC_SQL_For_Excel>(); }
        }
    }
}
