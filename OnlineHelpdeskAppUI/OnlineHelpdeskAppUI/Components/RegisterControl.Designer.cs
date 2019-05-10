namespace OnlineHelpdeskAppUI.Components
{
    partial class RegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_register = new System.Windows.Forms.Button();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(6, 289);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(211, 28);
            this.btn_register.TabIndex = 30;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(6, 247);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = '*';
            this.txbx_password.Size = new System.Drawing.Size(211, 22);
            this.txbx_password.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password:";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(6, 175);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(211, 22);
            this.txbx_email.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email:";
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(6, 103);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(211, 22);
            this.txbx_surname.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Surname:";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(6, 29);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(211, 22);
            this.txbx_name.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.label1);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(221, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_register;
        public System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
    }
}
