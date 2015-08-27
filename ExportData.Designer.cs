namespace ConnectDatabase
{
    partial class ExportData
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
            this.label1 = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Export_Confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SchemaComboBox = new System.Windows.Forms.ComboBox();
            this.AdvancedExport_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择表(Table)";
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(180, 58);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(319, 21);
            this.TableComboBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据预览";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(654, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // Export_Confirm
            // 
            this.Export_Confirm.Location = new System.Drawing.Point(543, 56);
            this.Export_Confirm.Name = "Export_Confirm";
            this.Export_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Export_Confirm.TabIndex = 9;
            this.Export_Confirm.Text = "执行导出";
            this.Export_Confirm.UseVisualStyleBackColor = true;
            this.Export_Confirm.Click += new System.EventHandler(this.Export_Confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "选择库(Schema)";
            // 
            // SchemaComboBox
            // 
            this.SchemaComboBox.FormattingEnabled = true;
            this.SchemaComboBox.Location = new System.Drawing.Point(180, 22);
            this.SchemaComboBox.Name = "SchemaComboBox";
            this.SchemaComboBox.Size = new System.Drawing.Size(319, 21);
            this.SchemaComboBox.TabIndex = 12;
            this.SchemaComboBox.TextChanged += new System.EventHandler(this.Schema_Changed);
            // 
            // AdvancedExport_Button
            // 
            this.AdvancedExport_Button.Location = new System.Drawing.Point(543, 20);
            this.AdvancedExport_Button.Name = "AdvancedExport_Button";
            this.AdvancedExport_Button.Size = new System.Drawing.Size(75, 23);
            this.AdvancedExport_Button.TabIndex = 13;
            this.AdvancedExport_Button.Text = "高级设置";
            this.AdvancedExport_Button.UseVisualStyleBackColor = true;
            this.AdvancedExport_Button.Click += new System.EventHandler(this.AdvancedExport_Click);
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 454);
            this.Controls.Add(this.AdvancedExport_Button);
            this.Controls.Add(this.SchemaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Export_Confirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportData";
            this.Text = "从数据库导出数据";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Export_Confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SchemaComboBox;
        public System.Windows.Forms.ComboBox TableComboBox;
        public System.Windows.Forms.Button AdvancedExport_Button;
    }
}