namespace OnlineHelpdeskAppUI
{
    partial class AddCardForm
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
            this.txbx_cardNumber = new System.Windows.Forms.TextBox();
            this.txbx_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_expireDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_addCard = new System.Windows.Forms.Button();
            this.lnkLbl_count = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number:";
            // 
            // txbx_cardNumber
            // 
            this.txbx_cardNumber.Location = new System.Drawing.Point(59, 65);
            this.txbx_cardNumber.Name = "txbx_cardNumber";
            this.txbx_cardNumber.Size = new System.Drawing.Size(354, 22);
            this.txbx_cardNumber.TabIndex = 1;
            // 
            // txbx_amount
            // 
            this.txbx_amount.Location = new System.Drawing.Point(59, 145);
            this.txbx_amount.Name = "txbx_amount";
            this.txbx_amount.Size = new System.Drawing.Size(354, 22);
            this.txbx_amount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // txbx_expireDate
            // 
            this.txbx_expireDate.Location = new System.Drawing.Point(59, 226);
            this.txbx_expireDate.Name = "txbx_expireDate";
            this.txbx_expireDate.Size = new System.Drawing.Size(354, 22);
            this.txbx_expireDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expire Date:";
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.MintCream;
            this.btn_generate.Location = new System.Drawing.Point(515, 64);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(136, 75);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_addCard
            // 
            this.btn_addCard.BackColor = System.Drawing.Color.MintCream;
            this.btn_addCard.Location = new System.Drawing.Point(515, 174);
            this.btn_addCard.Name = "btn_addCard";
            this.btn_addCard.Size = new System.Drawing.Size(136, 74);
            this.btn_addCard.TabIndex = 7;
            this.btn_addCard.Text = "Add Card";
            this.btn_addCard.UseVisualStyleBackColor = false;
            this.btn_addCard.Click += new System.EventHandler(this.btn_addCard_Click);
            // 
            // lnkLbl_count
            // 
            this.lnkLbl_count.AutoSize = true;
            this.lnkLbl_count.Location = new System.Drawing.Point(56, 280);
            this.lnkLbl_count.Name = "lnkLbl_count";
            this.lnkLbl_count.Size = new System.Drawing.Size(16, 17);
            this.lnkLbl_count.TabIndex = 8;
            this.lnkLbl_count.TabStop = true;
            this.lnkLbl_count.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "quantity of cards";
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(731, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkLbl_count);
            this.Controls.Add(this.btn_addCard);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txbx_expireDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_cardNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCardForm";
            this.Text = "Add Card";
            this.Load += new System.EventHandler(this.AddCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_cardNumber;
        private System.Windows.Forms.TextBox txbx_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_expireDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_addCard;
        private System.Windows.Forms.LinkLabel lnkLbl_count;
        private System.Windows.Forms.Label label4;
    }
}

