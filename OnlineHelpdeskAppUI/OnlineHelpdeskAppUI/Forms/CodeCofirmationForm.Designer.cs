namespace OnlineHelpdeskAppUI.Forms
{
    partial class CodeCofirmationForm
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
            this.txbx_code = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbx_code
            // 
            this.txbx_code.Location = new System.Drawing.Point(231, 52);
            this.txbx_code.Name = "txbx_code";
            this.txbx_code.Size = new System.Drawing.Size(145, 22);
            this.txbx_code.TabIndex = 0;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(231, 89);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(144, 23);
            this.btn_enter.TabIndex = 1;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please, enter code that we\'ve sent to your email\r\n";
            // 
            // CodeCofirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txbx_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodeCofirmationForm";
            this.Text = "CodeCofirmationForm";
            this.Load += new System.EventHandler(this.CodeCofirmationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_code;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label1;
    }
}