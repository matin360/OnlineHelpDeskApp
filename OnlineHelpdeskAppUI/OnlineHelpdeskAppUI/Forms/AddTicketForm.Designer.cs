namespace OnlineHelpdeskAppUI.Forms
{
    partial class AddTicketForm
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
            this.txbx_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txbx_decription = new System.Windows.Forms.RichTextBox();
            this.lbl_decsription = new System.Windows.Forms.Label();
            this.btn_addticket = new System.Windows.Forms.Button();
            this.link_number = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txbx_title
            // 
            this.txbx_title.Location = new System.Drawing.Point(52, 58);
            this.txbx_title.Name = "txbx_title";
            this.txbx_title.Size = new System.Drawing.Size(352, 22);
            this.txbx_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(52, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(35, 17);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title";
            // 
            // txbx_decription
            // 
            this.txbx_decription.Location = new System.Drawing.Point(52, 143);
            this.txbx_decription.Name = "txbx_decription";
            this.txbx_decription.Size = new System.Drawing.Size(352, 146);
            this.txbx_decription.TabIndex = 2;
            this.txbx_decription.Text = "";
            // 
            // lbl_decsription
            // 
            this.lbl_decsription.AutoSize = true;
            this.lbl_decsription.Location = new System.Drawing.Point(52, 120);
            this.lbl_decsription.Name = "lbl_decsription";
            this.lbl_decsription.Size = new System.Drawing.Size(79, 17);
            this.lbl_decsription.TabIndex = 3;
            this.lbl_decsription.Text = "Description";
            // 
            // btn_addticket
            // 
            this.btn_addticket.Location = new System.Drawing.Point(139, 328);
            this.btn_addticket.Name = "btn_addticket";
            this.btn_addticket.Size = new System.Drawing.Size(170, 41);
            this.btn_addticket.TabIndex = 4;
            this.btn_addticket.Text = "ADD";
            this.btn_addticket.UseVisualStyleBackColor = true;
            this.btn_addticket.Click += new System.EventHandler(this.btn_addticket_Click);
            // 
            // link_number
            // 
            this.link_number.AutoSize = true;
            this.link_number.Location = new System.Drawing.Point(350, 351);
            this.link_number.Name = "link_number";
            this.link_number.Size = new System.Drawing.Size(16, 17);
            this.link_number.TabIndex = 5;
            this.link_number.TabStop = true;
            this.link_number.Text = "0";
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 402);
            this.Controls.Add(this.link_number);
            this.Controls.Add(this.btn_addticket);
            this.Controls.Add(this.lbl_decsription);
            this.Controls.Add(this.txbx_decription);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txbx_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTicketForm";
            this.Text = "Add Ticket";
            this.Load += new System.EventHandler(this.AddTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox txbx_decription;
        private System.Windows.Forms.Label lbl_decsription;
        private System.Windows.Forms.Button btn_addticket;
        private System.Windows.Forms.LinkLabel link_number;
    }
}