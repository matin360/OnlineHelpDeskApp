namespace OnlineHelpdeskAppUI.Forms
{
    partial class LoginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txbx_login_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_login_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(39, 209);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(211, 28);
            this.btn_login.TabIndex = 25;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txbx_login_email
            // 
            this.txbx_login_email.Location = new System.Drawing.Point(39, 73);
            this.txbx_login_email.Name = "txbx_login_email";
            this.txbx_login_email.Size = new System.Drawing.Size(211, 22);
            this.txbx_login_email.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email:";
            // 
            // txbx_login_password
            // 
            this.txbx_login_password.Location = new System.Drawing.Point(39, 145);
            this.txbx_login_password.Name = "txbx_login_password";
            this.txbx_login_password.PasswordChar = '*';
            this.txbx_login_password.Size = new System.Drawing.Size(211, 22);
            this.txbx_login_password.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 278);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txbx_login_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_login_password);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txbx_login_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_login_password;
        private System.Windows.Forms.Label label7;
    }
}