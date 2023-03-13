namespace S2GroupProject.Forms
{
	partial class Days
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
			this.daysLb = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// daysLb
			// 
			this.daysLb.AutoSize = true;
			this.daysLb.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.daysLb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.daysLb.Location = new System.Drawing.Point(0, 0);
			this.daysLb.Name = "daysLb";
			this.daysLb.Size = new System.Drawing.Size(25, 20);
			this.daysLb.TabIndex = 0;
			this.daysLb.Text = "00";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(0, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "Show Employees";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Days
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.daysLb);
			this.Name = "Days";
			this.Size = new System.Drawing.Size(130, 130);
			this.Load += new System.EventHandler(this.Days_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label daysLb;
		private Button button1;
	}
}
