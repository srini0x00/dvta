namespace DVTA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lgnusername = new System.Windows.Forms.Label();
            this.txtLgnUsername = new System.Windows.Forms.TextBox();
            this.lgnpassword = new System.Windows.Forms.Label();
            this.txtLgnPass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.configserver = new System.Windows.Forms.Button();
            this.servertext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lgnusername
            // 
            this.lgnusername.AutoSize = true;
            this.lgnusername.Location = new System.Drawing.Point(133, 88);
            this.lgnusername.Name = "lgnusername";
            this.lgnusername.Size = new System.Drawing.Size(55, 13);
            this.lgnusername.TabIndex = 0;
            this.lgnusername.Text = "Username";
            this.lgnusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLgnUsername
            // 
            this.txtLgnUsername.Location = new System.Drawing.Point(225, 88);
            this.txtLgnUsername.Name = "txtLgnUsername";
            this.txtLgnUsername.Size = new System.Drawing.Size(154, 20);
            this.txtLgnUsername.TabIndex = 1;
            this.txtLgnUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lgnpassword
            // 
            this.lgnpassword.AutoSize = true;
            this.lgnpassword.Location = new System.Drawing.Point(133, 135);
            this.lgnpassword.Name = "lgnpassword";
            this.lgnpassword.Size = new System.Drawing.Size(53, 13);
            this.lgnpassword.TabIndex = 2;
            this.lgnpassword.Text = "Password";
            // 
            // txtLgnPass
            // 
            this.txtLgnPass.Location = new System.Drawing.Point(225, 135);
            this.txtLgnPass.Name = "txtLgnPass";
            this.txtLgnPass.Size = new System.Drawing.Size(154, 20);
            this.txtLgnPass.TabIndex = 3;
            this.txtLgnPass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(225, 206);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(134, 248);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(245, 23);
            this.btnregister.TabIndex = 5;
            this.btnregister.Text = "Dont have an account yet? Register Here";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnlgnregister);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(222, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login Here";
            // 
            // configserver
            // 
            this.configserver.Enabled = false;
            this.configserver.Location = new System.Drawing.Point(255, 363);
            this.configserver.Name = "configserver";
            this.configserver.Size = new System.Drawing.Size(191, 23);
            this.configserver.TabIndex = 7;
            this.configserver.Text = "Configure Server";
            this.configserver.UseVisualStyleBackColor = true;
            this.configserver.Click += new System.EventHandler(this.button1_Click);
            // 
            // servertext
            // 
            this.servertext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.servertext.Location = new System.Drawing.Point(90, 364);
            this.servertext.Name = "servertext";
            this.servertext.Size = new System.Drawing.Size(159, 20);
            this.servertext.TabIndex = 8;
            this.servertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.servertext);
            this.Controls.Add(this.configserver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtLgnPass);
            this.Controls.Add(this.lgnpassword);
            this.Controls.Add(this.txtLgnUsername);
            this.Controls.Add(this.lgnusername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgnusername;
        private System.Windows.Forms.TextBox txtLgnUsername;
        private System.Windows.Forms.Label lgnpassword;
        private System.Windows.Forms.TextBox txtLgnPass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button configserver;
        private System.Windows.Forms.TextBox servertext;
    }
}