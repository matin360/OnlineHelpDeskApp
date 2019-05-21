namespace OnlineHelpdeskAppUI.Components
{
    partial class TicketControl
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
            this.grbx_ticket = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_createdate = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_process = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_issue = new System.Windows.Forms.RichTextBox();
            this.grbx_ticket.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_ticket
            // 
            this.grbx_ticket.Controls.Add(this.txbx_issue);
            this.grbx_ticket.Controls.Add(this.lbl_id);
            this.grbx_ticket.Controls.Add(this.btn_close);
            this.grbx_ticket.Controls.Add(this.lbl_createdate);
            this.grbx_ticket.Controls.Add(this.lbl_status);
            this.grbx_ticket.Controls.Add(this.btn_process);
            this.grbx_ticket.Controls.Add(this.lbl_description);
            this.grbx_ticket.Controls.Add(this.label5);
            this.grbx_ticket.Controls.Add(this.lbl_title);
            this.grbx_ticket.Controls.Add(this.label2);
            this.grbx_ticket.Location = new System.Drawing.Point(3, 3);
            this.grbx_ticket.Name = "grbx_ticket";
            this.grbx_ticket.Size = new System.Drawing.Size(241, 466);
            this.grbx_ticket.TabIndex = 2;
            this.grbx_ticket.TabStop = false;
            this.grbx_ticket.Text = "Ticket";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(0, 371);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(128, 424);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 36);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_createdate
            // 
            this.lbl_createdate.AutoSize = true;
            this.lbl_createdate.Location = new System.Drawing.Point(6, 290);
            this.lbl_createdate.Name = "lbl_createdate";
            this.lbl_createdate.Size = new System.Drawing.Size(80, 17);
            this.lbl_createdate.TabIndex = 6;
            this.lbl_createdate.Text = "CreateDate";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(6, 247);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 17);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Status\r\n";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(23, 424);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(79, 36);
            this.btn_process.TabIndex = 4;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(6, 144);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(0, 17);
            this.lbl_description.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(6, 72);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 17);
            this.lbl_title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // txbx_issue
            // 
            this.txbx_issue.Location = new System.Drawing.Point(6, 324);
            this.txbx_issue.Name = "txbx_issue";
            this.txbx_issue.Size = new System.Drawing.Size(226, 94);
            this.txbx_issue.TabIndex = 9;
            this.txbx_issue.Text = "Issue...";
            // 
            // TicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbx_ticket);
            this.Name = "TicketControl";
            this.Size = new System.Drawing.Size(247, 472);
            this.grbx_ticket.ResumeLayout(false);
            this.grbx_ticket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grbx_ticket;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Label lbl_createdate;
        public System.Windows.Forms.Label lbl_status;
        public System.Windows.Forms.Button btn_process;
        public System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.RichTextBox txbx_issue;
    }
}
