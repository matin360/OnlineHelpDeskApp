namespace OnlineHelpdeskAppUI.Forms
{
    partial class RegisterForm
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
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_confirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_card_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_card_paswword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbx_cardNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_card_confirmPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_card_register = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_goToLoginPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(58, 57);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(211, 22);
            this.txbx_name.TabIndex = 1;
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(58, 131);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(211, 22);
            this.txbx_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(58, 203);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(211, 22);
            this.txbx_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(58, 275);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = '*';
            this.txbx_password.Size = new System.Drawing.Size(211, 22);
            this.txbx_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // txbx_confirmPassword
            // 
            this.txbx_confirmPassword.Location = new System.Drawing.Point(58, 358);
            this.txbx_confirmPassword.Name = "txbx_confirmPassword";
            this.txbx_confirmPassword.PasswordChar = '*';
            this.txbx_confirmPassword.Size = new System.Drawing.Size(211, 22);
            this.txbx_confirmPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password:";
            // 
            // txbx_card_email
            // 
            this.txbx_card_email.Location = new System.Drawing.Point(451, 131);
            this.txbx_card_email.Name = "txbx_card_email";
            this.txbx_card_email.Size = new System.Drawing.Size(211, 22);
            this.txbx_card_email.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // txbx_card_paswword
            // 
            this.txbx_card_paswword.Location = new System.Drawing.Point(451, 203);
            this.txbx_card_paswword.Name = "txbx_card_paswword";
            this.txbx_card_paswword.PasswordChar = '*';
            this.txbx_card_paswword.Size = new System.Drawing.Size(211, 22);
            this.txbx_card_paswword.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password:";
            // 
            // txbx_cardNumber
            // 
            this.txbx_cardNumber.Location = new System.Drawing.Point(451, 57);
            this.txbx_cardNumber.Name = "txbx_cardNumber";
            this.txbx_cardNumber.Size = new System.Drawing.Size(211, 22);
            this.txbx_cardNumber.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Card Number:";
            // 
            // txbx_card_confirmPassword
            // 
            this.txbx_card_confirmPassword.Location = new System.Drawing.Point(451, 275);
            this.txbx_card_confirmPassword.Name = "txbx_card_confirmPassword";
            this.txbx_card_confirmPassword.PasswordChar = '*';
            this.txbx_card_confirmPassword.Size = new System.Drawing.Size(211, 22);
            this.txbx_card_confirmPassword.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Confirm Passwod:";
            // 
            // btn_card_register
            // 
            this.btn_card_register.Location = new System.Drawing.Point(451, 329);
            this.btn_card_register.Name = "btn_card_register";
            this.btn_card_register.Size = new System.Drawing.Size(211, 28);
            this.btn_card_register.TabIndex = 18;
            this.btn_card_register.Text = "Register";
            this.btn_card_register.UseVisualStyleBackColor = true;
            this.btn_card_register.Click += new System.EventHandler(this.btn_card_register_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(58, 408);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(211, 28);
            this.btn_register.TabIndex = 19;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_goToLoginPage
            // 
            this.btn_goToLoginPage.Location = new System.Drawing.Point(451, 408);
            this.btn_goToLoginPage.Name = "btn_goToLoginPage";
            this.btn_goToLoginPage.Size = new System.Drawing.Size(211, 43);
            this.btn_goToLoginPage.TabIndex = 20;
            this.btn_goToLoginPage.Text = "Login Page";
            this.btn_goToLoginPage.UseVisualStyleBackColor = true;
            this.btn_goToLoginPage.Click += new System.EventHandler(this.Btn_goToLoginPage_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 476);
            this.Controls.Add(this.btn_goToLoginPage);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_card_register);
            this.Controls.Add(this.txbx_card_confirmPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbx_card_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_card_paswword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbx_cardNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbx_confirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_confirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_card_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_card_paswword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbx_cardNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_card_confirmPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_card_register;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_goToLoginPage;
    }
}