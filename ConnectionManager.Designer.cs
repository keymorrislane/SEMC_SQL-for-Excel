namespace ConnectDatabase
{
    partial class ConnectionManager
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
            this.HostNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HostAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DefaultSchemaTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionManagerButtonOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接名称";
            // 
            // HostNameComboBox
            // 
            this.HostNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.HostNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HostNameComboBox.FormattingEnabled = true;
            this.HostNameComboBox.Location = new System.Drawing.Point(141, 10);
            this.HostNameComboBox.Name = "HostNameComboBox";
            this.HostNameComboBox.Size = new System.Drawing.Size(346, 21);
            this.HostNameComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库地址";
            // 
            // HostAddressTextBox
            // 
            this.HostAddressTextBox.Location = new System.Drawing.Point(141, 55);
            this.HostAddressTextBox.Name = "HostAddressTextBox";
            this.HostAddressTextBox.Size = new System.Drawing.Size(181, 20);
            this.HostAddressTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "端口";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(387, 55);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 5;
            this.PortTextBox.Text = "3306";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "用户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "默认Schema";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(141, 101);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(346, 20);
            this.UserNameTextBox.TabIndex = 9;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(141, 140);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(346, 20);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // DefaultSchemaTextBox
            // 
            this.DefaultSchemaTextBox.Location = new System.Drawing.Point(141, 180);
            this.DefaultSchemaTextBox.Name = "DefaultSchemaTextBox";
            this.DefaultSchemaTextBox.Size = new System.Drawing.Size(346, 20);
            this.DefaultSchemaTextBox.TabIndex = 11;
            // 
            // ConnectionManagerButtonOK
            // 
            this.ConnectionManagerButtonOK.Location = new System.Drawing.Point(399, 234);
            this.ConnectionManagerButtonOK.Name = "ConnectionManagerButtonOK";
            this.ConnectionManagerButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ConnectionManagerButtonOK.TabIndex = 12;
            this.ConnectionManagerButtonOK.Text = "确定";
            this.ConnectionManagerButtonOK.UseVisualStyleBackColor = true;
            this.ConnectionManagerButtonOK.Click += new System.EventHandler(this.ConnectionManagerButtonOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConnectionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConnectionManagerButtonOK);
            this.Controls.Add(this.DefaultSchemaTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HostAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HostNameComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectionManager";
            this.Text = "连接管理器";
            this.Load += new System.EventHandler(this.ConnectionManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HostNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HostAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DefaultSchemaTextBox;
        private System.Windows.Forms.Button ConnectionManagerButtonOK;
        private System.Windows.Forms.Button button2;
    }
}