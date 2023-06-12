namespace S2GroupProject.Forms
{
    partial class EmployeePorfileUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePorfileUC));
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIcon
            // 
            this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
            this.UserIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserIcon.Location = new System.Drawing.Point(13, 2);
            this.UserIcon.Margin = new System.Windows.Forms.Padding(2);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(136, 84);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon.TabIndex = 6;
            this.UserIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeePorfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIcon);
            this.Name = "EmployeePorfileUC";
            this.Size = new System.Drawing.Size(166, 195);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmployeePorfileUC_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox UserIcon;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
