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
            this.label3 = new System.Windows.Forms.Label();
            this.MaxRow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MinRow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RowExcCheckBox = new System.Windows.Forms.CheckBox();
            this.RowIncCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColIncSearch = new System.Windows.Forms.TextBox();
            this.ColExcSearch = new System.Windows.Forms.TextBox();
            this.ColInc = new System.Windows.Forms.ListBox();
            this.ColExc = new System.Windows.Forms.ListBox();
            this.ColRemove = new System.Windows.Forms.Button();
            this.ColAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxCol = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.MinCol = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ColExcCheckBox = new System.Windows.Forms.CheckBox();
            this.ColIncCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterOK = new System.Windows.Forms.Button();
            this.FilterCancel = new System.Windows.Forms.Button();
            this.RowFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCol)).BeginInit();
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
            this.RowFilter.Controls.Add(this.label3);
            this.RowFilter.Controls.Add(this.MaxRow);
            this.RowFilter.Controls.Add(this.label2);
            this.RowFilter.Controls.Add(this.MinRow);
            this.RowFilter.Controls.Add(this.label1);
            this.RowFilter.Controls.Add(this.RowExcCheckBox);
            this.RowFilter.Controls.Add(this.RowIncCheckBox);
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
            this.RowIncSearch.Location = new System.Drawing.Point(236, 105);
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
            this.label5.Location = new System.Drawing.Point(236, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "要导入的行：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "要排除的行：";
            // 
            // RowInc
            // 
            this.RowInc.FormattingEnabled = true;
            this.RowInc.Location = new System.Drawing.Point(236, 131);
            this.RowInc.Name = "RowInc";
            this.RowInc.Size = new System.Drawing.Size(140, 160);
            this.RowInc.TabIndex = 27;
            // 
            // RowExcSearch
            // 
            this.RowExcSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RowExcSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.RowExcSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RowExcSearch.Location = new System.Drawing.Point(40, 105);
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
            this.keyCol.Location = new System.Drawing.Point(99, 45);
            this.keyCol.Name = "keyCol";
            this.keyCol.Size = new System.Drawing.Size(274, 21);
            this.keyCol.TabIndex = 12;
            this.keyCol.SelectedIndexChanged += new System.EventHandler(this.keyCol_Changed);
            // 
            // RowExc
            // 
            this.RowExc.FormattingEnabled = true;
            this.RowExc.Location = new System.Drawing.Point(40, 131);
            this.RowExc.Name = "RowExc";
            this.RowExc.Size = new System.Drawing.Size(140, 160);
            this.RowExc.TabIndex = 26;
            // 
            // RowRemove
            // 
            this.RowRemove.Location = new System.Drawing.Point(191, 232);
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
            this.label11.Location = new System.Drawing.Point(37, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "关键字列";
            // 
            // RowAdd
            // 
            this.RowAdd.Location = new System.Drawing.Point(191, 168);
            this.RowAdd.Name = "RowAdd";
            this.RowAdd.Size = new System.Drawing.Size(35, 35);
            this.RowAdd.TabIndex = 24;
            this.RowAdd.Text = "-->";
            this.RowAdd.UseVisualStyleBackColor = true;
            this.RowAdd.Click += new System.EventHandler(this.RowAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "行";
            // 
            // MaxRow
            // 
            this.MaxRow.Location = new System.Drawing.Point(301, 17);
            this.MaxRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxRow.Name = "MaxRow";
            this.MaxRow.Size = new System.Drawing.Size(52, 20);
            this.MaxRow.TabIndex = 5;
            this.MaxRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "至 第";
            // 
            // MinRow
            // 
            this.MinRow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinRow.Location = new System.Drawing.Point(196, 17);
            this.MinRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinRow.Name = "MinRow";
            this.MinRow.Size = new System.Drawing.Size(61, 20);
            this.MinRow.TabIndex = 3;
            this.MinRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "第";
            // 
            // RowExcCheckBox
            // 
            this.RowExcCheckBox.AutoSize = true;
            this.RowExcCheckBox.Location = new System.Drawing.Point(98, 19);
            this.RowExcCheckBox.Name = "RowExcCheckBox";
            this.RowExcCheckBox.Size = new System.Drawing.Size(50, 17);
            this.RowExcCheckBox.TabIndex = 1;
            this.RowExcCheckBox.Text = "排除";
            this.RowExcCheckBox.UseVisualStyleBackColor = true;
            this.RowExcCheckBox.CheckedChanged += new System.EventHandler(this.RowExc_CheckedChanged);
            // 
            // RowIncCheckBox
            // 
            this.RowIncCheckBox.AutoSize = true;
            this.RowIncCheckBox.Location = new System.Drawing.Point(40, 19);
            this.RowIncCheckBox.Name = "RowIncCheckBox";
            this.RowIncCheckBox.Size = new System.Drawing.Size(50, 17);
            this.RowIncCheckBox.TabIndex = 0;
            this.RowIncCheckBox.Text = "包含";
            this.RowIncCheckBox.UseVisualStyleBackColor = true;
            this.RowIncCheckBox.CheckedChanged += new System.EventHandler(this.RowInc_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MaxCol);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.MinCol);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ColExcCheckBox);
            this.groupBox2.Controls.Add(this.ColIncCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制列";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "要导入的列：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "要排除的列：";
            // 
            // ColIncSearch
            // 
            this.ColIncSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ColIncSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColIncSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ColIncSearch.Location = new System.Drawing.Point(236, 69);
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
            this.ColExcSearch.Location = new System.Drawing.Point(40, 69);
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
            this.ColInc.Location = new System.Drawing.Point(236, 95);
            this.ColInc.Name = "ColInc";
            this.ColInc.Size = new System.Drawing.Size(140, 160);
            this.ColInc.TabIndex = 23;
            // 
            // ColExc
            // 
            this.ColExc.FormattingEnabled = true;
            this.ColExc.Location = new System.Drawing.Point(40, 95);
            this.ColExc.Name = "ColExc";
            this.ColExc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ColExc.Size = new System.Drawing.Size(140, 160);
            this.ColExc.TabIndex = 22;
            // 
            // ColRemove
            // 
            this.ColRemove.Location = new System.Drawing.Point(191, 187);
            this.ColRemove.Name = "ColRemove";
            this.ColRemove.Size = new System.Drawing.Size(35, 35);
            this.ColRemove.TabIndex = 20;
            this.ColRemove.Text = "<--";
            this.ColRemove.UseVisualStyleBackColor = true;
            this.ColRemove.Click += new System.EventHandler(this.ColRemove_Click);
            // 
            // ColAdd
            // 
            this.ColAdd.Location = new System.Drawing.Point(191, 123);
            this.ColAdd.Name = "ColAdd";
            this.ColAdd.Size = new System.Drawing.Size(35, 35);
            this.ColAdd.TabIndex = 19;
            this.ColAdd.Text = "-->";
            this.ColAdd.UseVisualStyleBackColor = true;
            this.ColAdd.Click += new System.EventHandler(this.ColAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "列";
            // 
            // MaxCol
            // 
            this.MaxCol.Location = new System.Drawing.Point(303, 20);
            this.MaxCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxCol.Name = "MaxCol";
            this.MaxCol.Size = new System.Drawing.Size(52, 20);
            this.MaxCol.TabIndex = 16;
            this.MaxCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "至 第";
            // 
            // MinCol
            // 
            this.MinCol.Location = new System.Drawing.Point(198, 20);
            this.MinCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinCol.Name = "MinCol";
            this.MinCol.Size = new System.Drawing.Size(61, 20);
            this.MinCol.TabIndex = 14;
            this.MinCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "第";
            // 
            // ColExcCheckBox
            // 
            this.ColExcCheckBox.AutoSize = true;
            this.ColExcCheckBox.Location = new System.Drawing.Point(100, 22);
            this.ColExcCheckBox.Name = "ColExcCheckBox";
            this.ColExcCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ColExcCheckBox.TabIndex = 12;
            this.ColExcCheckBox.Text = "排除";
            this.ColExcCheckBox.UseVisualStyleBackColor = true;
            this.ColExcCheckBox.CheckedChanged += new System.EventHandler(this.ColExc_CheckedChanged);
            // 
            // ColIncCheckBox
            // 
            this.ColIncCheckBox.AutoSize = true;
            this.ColIncCheckBox.Location = new System.Drawing.Point(42, 22);
            this.ColIncCheckBox.Name = "ColIncCheckBox";
            this.ColIncCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ColIncCheckBox.TabIndex = 11;
            this.ColIncCheckBox.Text = "包含";
            this.ColIncCheckBox.UseVisualStyleBackColor = true;
            this.ColIncCheckBox.CheckedChanged += new System.EventHandler(this.ColInc_CheckedChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.MaxRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RowFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MaxRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MinRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RowExcCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MaxCol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown MinCol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ColExcCheckBox;
        private System.Windows.Forms.CheckBox ColIncCheckBox;
        private System.Windows.Forms.Button FilterOK;
        private System.Windows.Forms.Button FilterCancel;
        public System.Windows.Forms.CheckBox RowIncCheckBox;
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