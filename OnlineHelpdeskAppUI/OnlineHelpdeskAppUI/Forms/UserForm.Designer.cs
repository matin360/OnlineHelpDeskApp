namespace OnlineHelpdeskAppUI.Forms
{
    partial class UserForm
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
            this.lbl_greetings = new System.Windows.Forms.Label();
            this.link_addticket = new System.Windows.Forms.LinkLabel();
            this.link_tickets = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(695, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(93, 34);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_greetings
            // 
            this.lbl_greetings.AutoSize = true;
            this.lbl_greetings.Location = new System.Drawing.Point(25, 29);
            this.lbl_greetings.Name = "lbl_greetings";
            this.lbl_greetings.Size = new System.Drawing.Size(74, 17);
            this.lbl_greetings.TabIndex = 7;
            this.lbl_greetings.Text = "Welcome, ";
            // 
            // link_addticket
            // 
            this.link_addticket.AutoSize = true;
            this.link_addticket.Location = new System.Drawing.Point(28, 81);
            this.link_addticket.Name = "link_addticket";
            this.link_addticket.Size = new System.Drawing.Size(75, 17);
            this.link_addticket.TabIndex = 8;
            this.link_addticket.TabStop = true;
            this.link_addticket.Text = "Add Ticket";
            this.link_addticket.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_addticket_LinkClicked);
            // 
            // link_tickets
            // 
            this.link_tickets.AutoSize = true;
            this.link_tickets.Location = new System.Drawing.Point(31, 123);
            this.link_tickets.Name = "link_tickets";
            this.link_tickets.Size = new System.Drawing.Size(53, 17);
            this.link_tickets.TabIndex = 9;
            this.link_tickets.TabStop = true;
            this.link_tickets.Text = "Tickets";
            this.link_tickets.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_tickets_LinkClicked);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_tickets);
            this.Controls.Add(this.link_addticket);
            this.Controls.Add(this.lbl_greetings);
            this.Controls.Add(this.btn_logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_greetings;
        private System.Windows.Forms.LinkLabel link_addticket;
        private System.Windows.Forms.LinkLabel link_tickets;
    }
}