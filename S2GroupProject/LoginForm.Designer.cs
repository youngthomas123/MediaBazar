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
            LoginBT = new Button();
            ShowPasswordCB = new CheckBox();
            PasswordTB = new TextBox();
            UserNameTB = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginBT
            // 
            LoginBT.BackColor = SystemColors.ActiveCaptionText;
            LoginBT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBT.ForeColor = SystemColors.ButtonHighlight;
            LoginBT.Location = new Point(182, 350);
            LoginBT.Name = "LoginBT";
            LoginBT.Size = new Size(380, 48);
            LoginBT.TabIndex = 9;
            LoginBT.Text = "Login";
            LoginBT.UseVisualStyleBackColor = false;
            LoginBT.Click += LoginBT_Click;
            // 
            // ShowPasswordCB
            // 
            ShowPasswordCB.AutoSize = true;
            ShowPasswordCB.Location = new Point(288, 306);
            ShowPasswordCB.Name = "ShowPasswordCB";
            ShowPasswordCB.Size = new Size(162, 29);
            ShowPasswordCB.TabIndex = 8;
            ShowPasswordCB.Text = "Show Password";
            ShowPasswordCB.UseVisualStyleBackColor = true;
            // 
            // PasswordTB
            // 
            PasswordTB.ForeColor = Color.DarkGray;
            PasswordTB.Location = new Point(230, 257);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(332, 31);
            PasswordTB.TabIndex = 6;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // UserNameTB
            // 
            UserNameTB.ForeColor = Color.DarkGray;
            UserNameTB.Location = new Point(230, 191);
            UserNameTB.Name = "UserNameTB";
            UserNameTB.Size = new Size(332, 31);
            UserNameTB.TabIndex = 7;
            UserNameTB.TextChanged += UserNameTB_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(182, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(182, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 81);
            label1.Name = "label1";
            label1.Size = new Size(135, 48);
            label1.TabIndex = 10;
            label1.Text = "LOG IN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 571);
            Controls.Add(label1);
            Controls.Add(LoginBT);
            Controls.Add(ShowPasswordCB);
            Controls.Add(PasswordTB);
            Controls.Add(UserNameTB);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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