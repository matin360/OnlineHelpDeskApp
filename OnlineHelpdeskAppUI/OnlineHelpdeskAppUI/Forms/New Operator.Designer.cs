namespace OnlineHelpdeskAppUI.Forms
{
    partial class New_Operator
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
            this.registerControl = new OnlineHelpdeskAppUI.Components.RegisterControl();
            this.SuspendLayout();
            // 
            // registerControl
            // 
            this.registerControl.Location = new System.Drawing.Point(34, 35);
            this.registerControl.Name = "registerControl";
            this.registerControl.Size = new System.Drawing.Size(221, 322);
            this.registerControl.TabIndex = 0;
            // 
            // New_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 392);
            this.Controls.Add(this.registerControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "New_Operator";
            this.Text = "New_Operator";
            this.Load += new System.EventHandler(this.New_Operator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RegisterControl registerControl;
    }
}