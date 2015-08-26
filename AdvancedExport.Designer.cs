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
            this.keyCol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RowExcludeText = new System.Windows.Forms.RichTextBox();
            this.RowIncludeText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxRow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MinRow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RowExcCheckBox = new System.Windows.Forms.CheckBox();
            this.RowIncCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ColExcludeText = new System.Windows.Forms.RichTextBox();
            this.ColIncludeText = new System.Windows.Forms.RichTextBox();
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
            this.RowFilter.Controls.Add(this.keyCol);
            this.RowFilter.Controls.Add(this.label11);
            this.RowFilter.Controls.Add(this.label5);
            this.RowFilter.Controls.Add(this.label4);
            this.RowFilter.Controls.Add(this.RowExcludeText);
            this.RowFilter.Controls.Add(this.RowIncludeText);
            this.RowFilter.Controls.Add(this.label3);
            this.RowFilter.Controls.Add(this.MaxRow);
            this.RowFilter.Controls.Add(this.label2);
            this.RowFilter.Controls.Add(this.MinRow);
            this.RowFilter.Controls.Add(this.label1);
            this.RowFilter.Controls.Add(this.RowExcCheckBox);
            this.RowFilter.Controls.Add(this.RowIncCheckBox);
            this.RowFilter.Location = new System.Drawing.Point(12, 241);
            this.RowFilter.Name = "RowFilter";
            this.RowFilter.Size = new System.Drawing.Size(389, 245);
            this.RowFilter.TabIndex = 0;
            this.RowFilter.TabStop = false;
            this.RowFilter.Text = "控制行";
            this.RowFilter.Enter += new System.EventHandler(this.RowFilter_Enter);
            // 
            // keyCol
            // 
            this.keyCol.FormattingEnabled = true;
            this.keyCol.Location = new System.Drawing.Point(83, 45);
            this.keyCol.Name = "keyCol";
            this.keyCol.Size = new System.Drawing.Size(274, 21);
            this.keyCol.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "关键字列";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "排除下列关键字(多个关键字用逗号隔开)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "包含下列关键字(多个关键字用逗号隔开)：";
            // 
            // RowExcludeText
            // 
            this.RowExcludeText.Location = new System.Drawing.Point(22, 171);
            this.RowExcludeText.Name = "RowExcludeText";
            this.RowExcludeText.Size = new System.Drawing.Size(338, 56);
            this.RowExcludeText.TabIndex = 8;
            this.RowExcludeText.Text = "";
            // 
            // RowIncludeText
            // 
            this.RowIncludeText.Location = new System.Drawing.Point(22, 91);
            this.RowIncludeText.Name = "RowIncludeText";
            this.RowIncludeText.Size = new System.Drawing.Size(338, 56);
            this.RowIncludeText.TabIndex = 7;
            this.RowIncludeText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "行";
            // 
            // MaxRow
            // 
            this.MaxRow.Location = new System.Drawing.Point(280, 17);
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
            this.label2.Location = new System.Drawing.Point(242, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "至 第";
            // 
            // MinRow
            // 
            this.MinRow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinRow.Location = new System.Drawing.Point(175, 17);
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
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "第";
            // 
            // RowExcCheckBox
            // 
            this.RowExcCheckBox.AutoSize = true;
            this.RowExcCheckBox.Location = new System.Drawing.Point(77, 19);
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
            this.RowIncCheckBox.Location = new System.Drawing.Point(19, 19);
            this.RowIncCheckBox.Name = "RowIncCheckBox";
            this.RowIncCheckBox.Size = new System.Drawing.Size(50, 17);
            this.RowIncCheckBox.TabIndex = 0;
            this.RowIncCheckBox.Text = "包含";
            this.RowIncCheckBox.UseVisualStyleBackColor = true;
            this.RowIncCheckBox.CheckedChanged += new System.EventHandler(this.RowInc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ColExcludeText);
            this.groupBox2.Controls.Add(this.ColIncludeText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MaxCol);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.MinCol);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ColExcCheckBox);
            this.groupBox2.Controls.Add(this.ColIncCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制列";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "排除下列关键字(多个关键字用逗号隔开)：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "包含下列关键字(多个关键字用逗号隔开)：";
            // 
            // ColExcludeText
            // 
            this.ColExcludeText.Location = new System.Drawing.Point(25, 154);
            this.ColExcludeText.Name = "ColExcludeText";
            this.ColExcludeText.Size = new System.Drawing.Size(338, 56);
            this.ColExcludeText.TabIndex = 19;
            this.ColExcludeText.Text = "";
            // 
            // ColIncludeText
            // 
            this.ColIncludeText.Location = new System.Drawing.Point(25, 74);
            this.ColIncludeText.Name = "ColIncludeText";
            this.ColIncludeText.Size = new System.Drawing.Size(338, 56);
            this.ColIncludeText.TabIndex = 18;
            this.ColIncludeText.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "列";
            // 
            // MaxCol
            // 
            this.MaxCol.Location = new System.Drawing.Point(286, 19);
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
            this.label9.Location = new System.Drawing.Point(248, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "至 第";
            // 
            // MinCol
            // 
            this.MinCol.Location = new System.Drawing.Point(181, 19);
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
            this.label10.Location = new System.Drawing.Point(156, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "第";
            // 
            // ColExcCheckBox
            // 
            this.ColExcCheckBox.AutoSize = true;
            this.ColExcCheckBox.Location = new System.Drawing.Point(83, 21);
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
            this.ColIncCheckBox.Location = new System.Drawing.Point(25, 21);
            this.ColIncCheckBox.Name = "ColIncCheckBox";
            this.ColIncCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ColIncCheckBox.TabIndex = 11;
            this.ColIncCheckBox.Text = "包含";
            this.ColIncCheckBox.UseVisualStyleBackColor = true;
            this.ColIncCheckBox.CheckedChanged += new System.EventHandler(this.ColInc_CheckedChanged);
            // 
            // FilterOK
            // 
            this.FilterOK.Location = new System.Drawing.Point(222, 499);
            this.FilterOK.Name = "FilterOK";
            this.FilterOK.Size = new System.Drawing.Size(75, 23);
            this.FilterOK.TabIndex = 2;
            this.FilterOK.Text = "确定";
            this.FilterOK.UseVisualStyleBackColor = true;
            this.FilterOK.Click += new System.EventHandler(this.AdvancedExport_OK);
            // 
            // FilterCancel
            // 
            this.FilterCancel.Location = new System.Drawing.Point(320, 499);
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
            this.ClientSize = new System.Drawing.Size(413, 538);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RowExcludeText;
        private System.Windows.Forms.RichTextBox RowIncludeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MaxRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MinRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RowExcCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox ColExcludeText;
        private System.Windows.Forms.RichTextBox ColIncludeText;
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
    }
}