namespace S2GroupProject.Forms
{
    partial class LeaveMessageUC
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
            this.messagetb = new System.Windows.Forms.TextBox();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagetb
            // 
            this.messagetb.Location = new System.Drawing.Point(31, 20);
            this.messagetb.Multiline = true;
            this.messagetb.Name = "messagetb";
            this.messagetb.Size = new System.Drawing.Size(316, 81);
            this.messagetb.TabIndex = 0;
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(85, 141);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(196, 41);
            this.SendMessageBtn.TabIndex = 1;
            this.SendMessageBtn.Text = "Send Message";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // LeaveMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.messagetb);
            this.Name = "LeaveMessageUC";
            this.Size = new System.Drawing.Size(395, 213);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox messagetb;
        private Button SendMessageBtn;
    }
}
