namespace Logon
{
    partial class Logon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logon));
            this.button_logon = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_IPChoose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_logon
            // 
            this.button_logon.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_logon.Location = new System.Drawing.Point(72, 167);
            this.button_logon.Margin = new System.Windows.Forms.Padding(4);
            this.button_logon.Name = "button_logon";
            this.button_logon.Size = new System.Drawing.Size(85, 26);
            this.button_logon.TabIndex = 0;
            this.button_logon.Text = "登录";
            this.button_logon.UseVisualStyleBackColor = true;
            this.button_logon.Click += new System.EventHandler(this.button_logon_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(46, 39);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(68, 16);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "用户名:";
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwd.Location = new System.Drawing.Point(45, 79);
            this.passwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(69, 16);
            this.passwd.TabIndex = 2;
            this.passwd.Text = "密  码:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUserName.Location = new System.Drawing.Point(122, 36);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(164, 26);
            this.textBoxUserName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassword.Location = new System.Drawing.Point(122, 79);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(164, 26);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Exit.Location = new System.Drawing.Point(191, 167);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(85, 26);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "退出";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "选  项:";
            // 
            // comboBox_IPChoose
            // 
            this.comboBox_IPChoose.FormattingEnabled = true;
            this.comboBox_IPChoose.Location = new System.Drawing.Point(122, 120);
            this.comboBox_IPChoose.Name = "comboBox_IPChoose";
            this.comboBox_IPChoose.Size = new System.Drawing.Size(121, 27);
            this.comboBox_IPChoose.TabIndex = 8;
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(354, 216);
            this.Controls.Add(this.comboBox_IPChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.button_logon);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logon;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_IPChoose;
    }
}

