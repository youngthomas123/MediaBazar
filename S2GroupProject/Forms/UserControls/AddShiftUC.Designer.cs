namespace S2GroupProject.Forms
{
    partial class AddShiftUC
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
            this.AddShiftBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddShiftBtn
            // 
            this.AddShiftBtn.Location = new System.Drawing.Point(3, 301);
            this.AddShiftBtn.Name = "AddShiftBtn";
            this.AddShiftBtn.Size = new System.Drawing.Size(129, 40);
            this.AddShiftBtn.TabIndex = 0;
            this.AddShiftBtn.Text = "AddShift";
            this.AddShiftBtn.UseVisualStyleBackColor = true;
            this.AddShiftBtn.Click += new System.EventHandler(this.AddShiftBtn_Click);
            // 
            // AddShiftUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddShiftBtn);
            this.Name = "AddShiftUC";
            this.Size = new System.Drawing.Size(1244, 403);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddShiftBtn;
    }
}
