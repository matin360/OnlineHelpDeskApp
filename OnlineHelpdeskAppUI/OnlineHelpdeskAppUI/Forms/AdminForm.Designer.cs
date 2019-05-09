namespace OnlineHelpdeskAppUI.Forms
{
    partial class AdminForm
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.link_addcard = new System.Windows.Forms.LinkLabel();
            this.link_cards = new System.Windows.Forms.LinkLabel();
            this.link_users = new System.Windows.Forms.LinkLabel();
            this.lbl_greetings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(695, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(93, 34);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // link_addcard
            // 
            this.link_addcard.AutoSize = true;
            this.link_addcard.Location = new System.Drawing.Point(26, 114);
            this.link_addcard.Name = "link_addcard";
            this.link_addcard.Size = new System.Drawing.Size(67, 17);
            this.link_addcard.TabIndex = 3;
            this.link_addcard.TabStop = true;
            this.link_addcard.Text = "Add Card";
            this.link_addcard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_addcard_LinkClicked);
            // 
            // link_cards
            // 
            this.link_cards.AutoSize = true;
            this.link_cards.Location = new System.Drawing.Point(26, 173);
            this.link_cards.Name = "link_cards";
            this.link_cards.Size = new System.Drawing.Size(45, 17);
            this.link_cards.TabIndex = 4;
            this.link_cards.TabStop = true;
            this.link_cards.Text = "Cards";
            this.link_cards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cards_LinkClicked);
            // 
            // link_users
            // 
            this.link_users.AutoSize = true;
            this.link_users.Location = new System.Drawing.Point(26, 227);
            this.link_users.Name = "link_users";
            this.link_users.Size = new System.Drawing.Size(45, 17);
            this.link_users.TabIndex = 5;
            this.link_users.TabStop = true;
            this.link_users.Text = "Users";
            this.link_users.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_users_LinkClicked);
            // 
            // lbl_greetings
            // 
            this.lbl_greetings.AutoSize = true;
            this.lbl_greetings.Location = new System.Drawing.Point(25, 29);
            this.lbl_greetings.Name = "lbl_greetings";
            this.lbl_greetings.Size = new System.Drawing.Size(74, 17);
            this.lbl_greetings.TabIndex = 6;
            this.lbl_greetings.Text = "Welcome, ";
            this.lbl_greetings.Click += new System.EventHandler(this.lbl_greetings_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_greetings);
            this.Controls.Add(this.link_users);
            this.Controls.Add(this.link_cards);
            this.Controls.Add(this.link_addcard);
            this.Controls.Add(this.btn_logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.LinkLabel link_addcard;
        private System.Windows.Forms.LinkLabel link_cards;
        private System.Windows.Forms.LinkLabel link_users;
        private System.Windows.Forms.Label lbl_greetings;
    }
}