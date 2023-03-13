namespace S2GroupProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginBT = new System.Windows.Forms.Button();
            this.ShowPasswordCB = new System.Windows.Forms.CheckBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBT
            // 
            this.LoginBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBT.Location = new System.Drawing.Point(127, 210);
            this.LoginBT.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(266, 36);
            this.LoginBT.TabIndex = 9;
            this.LoginBT.Text = "Login";
            this.LoginBT.UseVisualStyleBackColor = false;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click_1);
            // 
            // ShowPasswordCB
            // 
            this.ShowPasswordCB.AutoSize = true;
            this.ShowPasswordCB.Location = new System.Drawing.Point(202, 184);
            this.ShowPasswordCB.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPasswordCB.Name = "ShowPasswordCB";
            this.ShowPasswordCB.Size = new System.Drawing.Size(108, 19);
            this.ShowPasswordCB.TabIndex = 8;
            this.ShowPasswordCB.Text = "Show Password";
            this.ShowPasswordCB.UseVisualStyleBackColor = true;
            // 
            // PasswordTB
            // 
            this.PasswordTB.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTB.Location = new System.Drawing.Point(161, 154);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(234, 23);
            this.PasswordTB.TabIndex = 6;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // UserNameTB
            // 
            this.UserNameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.UserNameTB.Location = new System.Drawing.Point(161, 115);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(234, 23);
            this.UserNameTB.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(127, 151);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(127, 111);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOG IN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.ShowPasswordCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginBT;
        private CheckBox ShowPasswordCB;
        private TextBox PasswordTB;
        private TextBox UserNameTB;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
    }
}