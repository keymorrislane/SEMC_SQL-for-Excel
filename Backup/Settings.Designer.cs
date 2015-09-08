namespace SSEBasicVersion
{
    partial class Settings
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ChooseTime = new System.Windows.Forms.GroupBox();
            this.EndDay = new System.Windows.Forms.NumericUpDown();
            this.EndMonth = new System.Windows.Forms.NumericUpDown();
            this.EndYear = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BeginDay = new System.Windows.Forms.NumericUpDown();
            this.BeginMonth = new System.Windows.Forms.NumericUpDown();
            this.BeginYear = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.ChoosePoint = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ChooseTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginYear)).BeginInit();
            this.ChoosePoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(347, 264);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(440, 264);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ChooseTime
            // 
            this.ChooseTime.Controls.Add(this.EndDay);
            this.ChooseTime.Controls.Add(this.EndMonth);
            this.ChooseTime.Controls.Add(this.EndYear);
            this.ChooseTime.Controls.Add(this.label10);
            this.ChooseTime.Controls.Add(this.label11);
            this.ChooseTime.Controls.Add(this.label12);
            this.ChooseTime.Controls.Add(this.label13);
            this.ChooseTime.Controls.Add(this.BeginDay);
            this.ChooseTime.Controls.Add(this.BeginMonth);
            this.ChooseTime.Controls.Add(this.BeginYear);
            this.ChooseTime.Controls.Add(this.label3);
            this.ChooseTime.Controls.Add(this.label2);
            this.ChooseTime.Controls.Add(this.label1);
            this.ChooseTime.Controls.Add(this.Start);
            this.ChooseTime.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTime.Location = new System.Drawing.Point(12, 12);
            this.ChooseTime.Name = "ChooseTime";
            this.ChooseTime.Size = new System.Drawing.Size(509, 80);
            this.ChooseTime.TabIndex = 2;
            this.ChooseTime.TabStop = false;
            this.ChooseTime.Text = "选择时间";
            // 
            // EndDay
            // 
            this.EndDay.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndDay.Location = new System.Drawing.Point(299, 47);
            this.EndDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.EndDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(40, 25);
            this.EndDay.TabIndex = 22;
            this.EndDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndMonth
            // 
            this.EndMonth.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndMonth.Location = new System.Drawing.Point(210, 47);
            this.EndMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.EndMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndMonth.Name = "EndMonth";
            this.EndMonth.Size = new System.Drawing.Size(40, 25);
            this.EndMonth.TabIndex = 21;
            this.EndMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndYear
            // 
            this.EndYear.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndYear.Location = new System.Drawing.Point(82, 47);
            this.EndYear.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.EndYear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(79, 25);
            this.EndYear.TabIndex = 20;
            this.EndYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.EndYear.ValueChanged += new System.EventHandler(this.EndYear_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "日";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "月";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(167, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "年";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "结束时间：";
            // 
            // BeginDay
            // 
            this.BeginDay.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginDay.Location = new System.Drawing.Point(299, 18);
            this.BeginDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.BeginDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BeginDay.Name = "BeginDay";
            this.BeginDay.Size = new System.Drawing.Size(40, 25);
            this.BeginDay.TabIndex = 9;
            this.BeginDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BeginMonth
            // 
            this.BeginMonth.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginMonth.Location = new System.Drawing.Point(210, 18);
            this.BeginMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.BeginMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BeginMonth.Name = "BeginMonth";
            this.BeginMonth.Size = new System.Drawing.Size(40, 25);
            this.BeginMonth.TabIndex = 8;
            this.BeginMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BeginYear
            // 
            this.BeginYear.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginYear.Location = new System.Drawing.Point(82, 18);
            this.BeginYear.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.BeginYear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.BeginYear.Name = "BeginYear";
            this.BeginYear.Size = new System.Drawing.Size(79, 25);
            this.BeginYear.TabIndex = 7;
            this.BeginYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.BeginYear.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "月";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "年";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(8, 22);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(68, 17);
            this.Start.TabIndex = 0;
            this.Start.Text = "起始时间：";
            // 
            // ChoosePoint
            // 
            this.ChoosePoint.Controls.Add(this.checkedListBox1);
            this.ChoosePoint.Controls.Add(this.checkBox1);
            this.ChoosePoint.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePoint.Location = new System.Drawing.Point(13, 99);
            this.ChoosePoint.Name = "ChoosePoint";
            this.ChoosePoint.Size = new System.Drawing.Size(508, 159);
            this.ChoosePoint.TabIndex = 3;
            this.ChoosePoint.TabStop = false;
            this.ChoosePoint.Text = "选择监测点位";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(9, 47);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(493, 104);
            this.checkedListBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(12, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "全选";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 299);
            this.Controls.Add(this.ChoosePoint);
            this.Controls.Add(this.ChooseTime);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据选择";
            this.ChooseTime.ResumeLayout(false);
            this.ChooseTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginYear)).EndInit();
            this.ChoosePoint.ResumeLayout(false);
            this.ChoosePoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox ChooseTime;
        private System.Windows.Forms.NumericUpDown BeginYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.GroupBox ChoosePoint;
        private System.Windows.Forms.NumericUpDown EndDay;
        private System.Windows.Forms.NumericUpDown EndMonth;
        private System.Windows.Forms.NumericUpDown EndYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown BeginDay;
        private System.Windows.Forms.NumericUpDown BeginMonth;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}