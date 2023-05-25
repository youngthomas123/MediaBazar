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
			resources.ApplyResources(LoginBT, "LoginBT");
			LoginBT.ForeColor = SystemColors.ButtonHighlight;
			LoginBT.Name = "LoginBT";
			LoginBT.UseVisualStyleBackColor = false;
			LoginBT.Click += LoginBT_Click_1;
			// 
			// ShowPasswordCB
			// 
			resources.ApplyResources(ShowPasswordCB, "ShowPasswordCB");
			ShowPasswordCB.Name = "ShowPasswordCB";
			ShowPasswordCB.UseVisualStyleBackColor = true;
			// 
			// PasswordTB
			// 
			PasswordTB.ForeColor = Color.DarkGray;
			resources.ApplyResources(PasswordTB, "PasswordTB");
			PasswordTB.Name = "PasswordTB";
			PasswordTB.UseSystemPasswordChar = true;
			// 
			// UserNameTB
			// 
			UserNameTB.ForeColor = Color.DarkGray;
			resources.ApplyResources(UserNameTB, "UserNameTB");
			UserNameTB.Name = "UserNameTB";
			// 
			// pictureBox3
			// 
			resources.ApplyResources(pictureBox3, "pictureBox3");
			pictureBox3.Name = "pictureBox3";
			pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			resources.ApplyResources(pictureBox2, "pictureBox2");
			pictureBox2.Name = "pictureBox2";
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// LoginForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Moccasin;
			Controls.Add(label1);
			Controls.Add(LoginBT);
			Controls.Add(ShowPasswordCB);
			Controls.Add(PasswordTB);
			Controls.Add(UserNameTB);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Name = "LoginForm";
			Load += LoginForm_Load;
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