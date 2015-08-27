namespace ConnectDatabase
{
    partial class AdvancedExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RowFilter = new System.Windows.Forms.GroupBox();
            this.RowIncSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RowInc = new System.Windows.Forms.ListBox();
            this.RowExcSearch = new System.Windows.Forms.TextBox();
            this.keyCol = new System.Windows.Forms.ComboBox();
            this.RowExc = new System.Windows.Forms.ListBox();
            this.RowRemove = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.RowAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColIncSearch = new System.Windows.Forms.TextBox();
            this.ColExcSearch = new System.Windows.Forms.TextBox();
            this.ColInc = new System.Windows.Forms.ListBox();
            this.ColExc = new System.Windows.Forms.ListBox();
            this.ColRemove = new System.Windows.Forms.Button();
            this.ColAdd = new System.Windows.Forms.Button();
            this.FilterOK = new System.Windows.Forms.Button();
            this.FilterCancel = new System.Windows.Forms.Button();
            this.RowFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RowFilter
            // 
            this.RowFilter.Controls.Add(this.RowIncSearch);
            this.RowFilter.Controls.Add(this.label5);
            this.RowFilter.Controls.Add(this.label6);
            this.RowFilter.Controls.Add(this.RowInc);
            this.RowFilter.Controls.Add(this.RowExcSearch);
            this.RowFilter.Controls.Add(this.keyCol);
            this.RowFilter.Controls.Add(this.RowExc);
            this.RowFilter.Controls.Add(this.RowRemove);
            this.RowFilter.Controls.Add(this.label11);
            this.RowFilter.Controls.Add(this.RowAdd);
            this.RowFilter.Location = new System.Drawing.Point(18, 279);
            this.RowFilter.Name = "RowFilter";
            this.RowFilter.Size = new System.Drawing.Size(418, 313);
            this.RowFilter.TabIndex = 0;
            this.RowFilter.TabStop = false;
            this.RowFilter.Text = "控制行";
            this.RowFilter.Enter += new System.EventHandler(this.RowFilter_Enter);
            // 
            // RowIncSearch
            // 
            this.RowIncSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RowIncSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.RowIncSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RowIncSearch.Location = new System.Drawing.Point(239, 79);
            this.RowIncSearch.Name = "RowIncSearch";
            this.RowIncSearch.Size = new System.Drawing.Size(140, 20);
            this.RowIncSearch.TabIndex = 27;
            this.RowIncSearch.Text = "搜索";
            this.RowIncSearch.TextChanged += new System.EventHandler(this.Search_Changed);
            this.RowIncSearch.Enter += new System.EventHandler(this.Search_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "要导入的行：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "待选行：";
            // 
            // RowInc
            // 
            this.RowInc.FormattingEnabled = true;
            this.RowInc.Location = new System.Drawing.Point(239, 105);
            this.RowInc.Name = "RowInc";
            this.RowInc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RowInc.Size = new System.Drawing.Size(140, 199);
            this.RowInc.TabIndex = 27;
            // 
            // RowExcSearch
            // 
            this.RowExcSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RowExcSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.RowExcSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RowExcSearch.Location = new System.Drawing.Point(43, 79);
            this.RowExcSearch.Name = "RowExcSearch";
            this.RowExcSearch.Size = new System.Drawing.Size(140, 20);
            this.RowExcSearch.TabIndex = 26;
            this.RowExcSearch.Text = "搜索";
            this.RowExcSearch.TextChanged += new System.EventHandler(this.Search_Changed);
            this.RowExcSearch.Enter += new System.EventHandler(this.Search_Enter);
            // 
            // keyCol
            // 
            this.keyCol.FormattingEnabled = true;
            this.keyCol.Location = new System.Drawing.Point(102, 19);
            this.keyCol.Name = "keyCol";
            this.keyCol.Size = new System.Drawing.Size(274, 21);
            this.keyCol.TabIndex = 12;
            this.keyCol.SelectedIndexChanged += new System.EventHandler(this.keyCol_Changed);
            // 
            // RowExc
            // 
            this.RowExc.FormattingEnabled = true;
            this.RowExc.Location = new System.Drawing.Point(43, 105);
            this.RowExc.Name = "RowExc";
            this.RowExc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RowExc.Size = new System.Drawing.Size(140, 199);
            this.RowExc.TabIndex = 26;
            // 
            // RowRemove
            // 
            this.RowRemove.Location = new System.Drawing.Point(194, 206);
            this.RowRemove.Name = "RowRemove";
            this.RowRemove.Size = new System.Drawing.Size(35, 35);
            this.RowRemove.TabIndex = 25;
            this.RowRemove.Text = "<--";
            this.RowRemove.UseVisualStyleBackColor = true;
            this.RowRemove.Click += new System.EventHandler(this.RowRemove_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "关键字列";
            // 
            // RowAdd
            // 
            this.RowAdd.Location = new System.Drawing.Point(194, 142);
            this.RowAdd.Name = "RowAdd";
            this.RowAdd.Size = new System.Drawing.Size(35, 35);
            this.RowAdd.TabIndex = 24;
            this.RowAdd.Text = "-->";
            this.RowAdd.UseVisualStyleBackColor = true;
            this.RowAdd.Click += new System.EventHandler(this.RowAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ColIncSearch);
            this.groupBox2.Controls.Add(this.ColExcSearch);
            this.groupBox2.Controls.Add(this.ColInc);
            this.groupBox2.Controls.Add(this.ColExc);
            this.groupBox2.Controls.Add(this.ColRemove);
            this.groupBox2.Controls.Add(this.ColAdd);
            this.groupBox2.Location = new System.Drawing.Point(18, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制列";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "要导入的列：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "待选列：";
            // 
            // ColIncSearch
            // 
            this.ColIncSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ColIncSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColIncSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ColIncSearch.Location = new System.Drawing.Point(236, 42);
            this.ColIncSearch.Name = "ColIncSearch";
            this.ColIncSearch.Size = new System.Drawing.Size(140, 20);
            this.ColIncSearch.TabIndex = 25;
            this.ColIncSearch.Text = "搜索";
            this.ColIncSearch.TextChanged += new System.EventHandler(this.Search_Changed);
            this.ColIncSearch.Enter += new System.EventHandler(this.Search_Enter);
            // 
            // ColExcSearch
            // 
            this.ColExcSearch.AcceptsReturn = true;
            this.ColExcSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ColExcSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColExcSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ColExcSearch.Location = new System.Drawing.Point(40, 42);
            this.ColExcSearch.Name = "ColExcSearch";
            this.ColExcSearch.Size = new System.Drawing.Size(140, 20);
            this.ColExcSearch.TabIndex = 24;
            this.ColExcSearch.Text = "搜索";
            this.ColExcSearch.TextChanged += new System.EventHandler(this.Search_Changed);
            this.ColExcSearch.Enter += new System.EventHandler(this.Search_Enter);
            // 
            // ColInc
            // 
            this.ColInc.FormattingEnabled = true;
            this.ColInc.Location = new System.Drawing.Point(236, 69);
            this.ColInc.Name = "ColInc";
            this.ColInc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ColInc.Size = new System.Drawing.Size(140, 160);
            this.ColInc.TabIndex = 23;
            // 
            // ColExc
            // 
            this.ColExc.FormattingEnabled = true;
            this.ColExc.Location = new System.Drawing.Point(40, 69);
            this.ColExc.Name = "ColExc";
            this.ColExc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ColExc.Size = new System.Drawing.Size(140, 160);
            this.ColExc.TabIndex = 22;
            // 
            // ColRemove
            // 
            this.ColRemove.Location = new System.Drawing.Point(191, 127);
            this.ColRemove.Name = "ColRemove";
            this.ColRemove.Size = new System.Drawing.Size(35, 35);
            this.ColRemove.TabIndex = 20;
            this.ColRemove.Text = "<--";
            this.ColRemove.UseVisualStyleBackColor = true;
            this.ColRemove.Click += new System.EventHandler(this.ColRemove_Click);
            // 
            // ColAdd
            // 
            this.ColAdd.Location = new System.Drawing.Point(191, 69);
            this.ColAdd.Name = "ColAdd";
            this.ColAdd.Size = new System.Drawing.Size(35, 35);
            this.ColAdd.TabIndex = 19;
            this.ColAdd.Text = "-->";
            this.ColAdd.UseVisualStyleBackColor = true;
            this.ColAdd.Click += new System.EventHandler(this.ColAdd_Click);
            // 
            // FilterOK
            // 
            this.FilterOK.Location = new System.Drawing.Point(257, 600);
            this.FilterOK.Name = "FilterOK";
            this.FilterOK.Size = new System.Drawing.Size(75, 23);
            this.FilterOK.TabIndex = 2;
            this.FilterOK.Text = "确定";
            this.FilterOK.UseVisualStyleBackColor = true;
            this.FilterOK.Click += new System.EventHandler(this.AdvancedExport_OK);
            // 
            // FilterCancel
            // 
            this.FilterCancel.Location = new System.Drawing.Point(355, 600);
            this.FilterCancel.Name = "FilterCancel";
            this.FilterCancel.Size = new System.Drawing.Size(75, 23);
            this.FilterCancel.TabIndex = 3;
            this.FilterCancel.Text = "取消";
            this.FilterCancel.UseVisualStyleBackColor = true;
            this.FilterCancel.Click += new System.EventHandler(this.AdvancedExport_Cancel);
            // 
            // AdvancedExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 635);
            this.Controls.Add(this.FilterCancel);
            this.Controls.Add(this.FilterOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RowFilter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "高级导出";
            this.RowFilter.ResumeLayout(false);
            this.RowFilter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RowFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FilterOK;
        private System.Windows.Forms.Button FilterCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox keyCol;
        private System.Windows.Forms.TextBox RowIncSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox RowInc;
        private System.Windows.Forms.TextBox RowExcSearch;
        private System.Windows.Forms.ListBox RowExc;
        private System.Windows.Forms.Button RowRemove;
        private System.Windows.Forms.Button RowAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColIncSearch;
        private System.Windows.Forms.TextBox ColExcSearch;
        private System.Windows.Forms.ListBox ColInc;
        private System.Windows.Forms.ListBox ColExc;
        private System.Windows.Forms.Button ColRemove;
        private System.Windows.Forms.Button ColAdd;
    }
}