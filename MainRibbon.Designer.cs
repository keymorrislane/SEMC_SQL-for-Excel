namespace SSEBasicVersion
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbon));
            this.SSM = this.Factory.CreateRibbonTab();
            this.key = this.Factory.CreateRibbonGroup();
            this.Import = this.Factory.CreateRibbonButton();
            this.SSM.SuspendLayout();
            this.key.SuspendLayout();
            // 
            // SSM
            // 
            this.SSM.Groups.Add(this.key);
            this.SSM.Label = "温湿度数据导出";
            this.SSM.Name = "SSM";
            // 
            // key
            // 
            this.key.Items.Add(this.Import);
            this.key.Name = "key";
            // 
            // Import
            // 
            this.Import.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Import.Description = "从MySQL中导出监测数据。";
            this.Import.Image = ((System.Drawing.Image)(resources.GetObject("Import.Image")));
            this.Import.Label = "导出监测数据";
            this.Import.Name = "Import";
            this.Import.ShowImage = true;
            this.Import.SuperTip = "从MySQL数据库中导出监测数据";
            this.Import.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Import_Click);
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.SSM);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.SSM.ResumeLayout(false);
            this.SSM.PerformLayout();
            this.key.ResumeLayout(false);
            this.key.PerformLayout();

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup key;
        public Microsoft.Office.Tools.Ribbon.RibbonTab SSM;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Import;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon Ribbon1
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}
