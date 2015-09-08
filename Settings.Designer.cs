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
            this.EndDay = new System.Windows.Forms.NumericUpDown();
            this.Cancel = new System.Windows.Forms.Button();
            this.EndMonth = new System.Windows.Forms.NumericUpDown();
            this.Confirm = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.EndDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginYear)).BeginInit();
            this.SuspendLayout();
            // 
            // EndDay
            // 
            this.EndDay.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndDay.Location = new System.Drawing.Point(321, 52);
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
            this.EndDay.TabIndex = 38;
            this.EndDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(432, 52);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 25);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EndMonth
            // 
            this.EndMonth.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndMonth.Location = new System.Drawing.Point(232, 52);
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
            this.EndMonth.TabIndex = 37;
            this.EndMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold);
            this.Confirm.Location = new System.Drawing.Point(432, 15);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 25);
            this.Confirm.TabIndex = 23;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // EndYear
            // 
            this.EndYear.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndYear.Location = new System.Drawing.Point(104, 52);
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
            this.EndYear.TabIndex = 36;
            this.EndYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "日";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "月";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(189, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "年";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "结束时间：";
            // 
            // BeginDay
            // 
            this.BeginDay.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginDay.Location = new System.Drawing.Point(321, 15);
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
            this.BeginDay.TabIndex = 31;
            this.BeginDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BeginMonth
            // 
            this.BeginMonth.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginMonth.Location = new System.Drawing.Point(232, 15);
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
            this.BeginMonth.TabIndex = 30;
            this.BeginMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BeginYear
            // 
            this.BeginYear.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginYear.Location = new System.Drawing.Point(104, 15);
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
            this.BeginYear.TabIndex = 29;
            this.BeginYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "月";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "年";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(30, 20);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(68, 17);
            this.Start.TabIndex = 24;
            this.Start.Text = "起始时间：";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 94);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EndMonth);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.EndYear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BeginDay);
            this.Controls.Add(this.BeginMonth);
            this.Controls.Add(this.BeginYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据选择";
            ((System.ComponentModel.ISupportInitialize)(this.EndDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown EndDay;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown EndMonth;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.NumericUpDown EndYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown BeginDay;
        private System.Windows.Forms.NumericUpDown BeginMonth;
        private System.Windows.Forms.NumericUpDown BeginYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Start;

    }
}