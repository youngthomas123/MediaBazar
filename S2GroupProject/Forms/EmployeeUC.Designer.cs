namespace S2GroupProject
{
	partial class EmployeeUC
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
            this.employeeName = new System.Windows.Forms.Label();
            this.bsn = new System.Windows.Forms.Label();
            this.telNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeShiftLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeName.Location = new System.Drawing.Point(70, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(74, 30);
            this.employeeName.TabIndex = 0;
            this.employeeName.Text = "Name:";
            // 
            // bsn
            // 
            this.bsn.AutoSize = true;
            this.bsn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bsn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bsn.Location = new System.Drawing.Point(54, 30);
            this.bsn.Name = "bsn";
            this.bsn.Size = new System.Drawing.Size(57, 30);
            this.bsn.TabIndex = 1;
            this.bsn.Text = "BSN:";
            // 
            // telNumber
            // 
            this.telNumber.AutoSize = true;
            this.telNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telNumber.Location = new System.Drawing.Point(91, 60);
            this.telNumber.Name = "telNumber";
            this.telNumber.Size = new System.Drawing.Size(94, 30);
            this.telNumber.TabIndex = 2;
            this.telNumber.Text = "Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "BSN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // employeeShiftLb
            // 
            this.employeeShiftLb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeShiftLb.FormattingEnabled = true;
            this.employeeShiftLb.ItemHeight = 30;
            this.employeeShiftLb.Location = new System.Drawing.Point(-3, 116);
            this.employeeShiftLb.Name = "employeeShiftLb";
            this.employeeShiftLb.Size = new System.Drawing.Size(520, 244);
            this.employeeShiftLb.TabIndex = 6;
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeShiftLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telNumber);
            this.Controls.Add(this.bsn);
            this.Controls.Add(this.employeeName);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(517, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Label employeeName;
        private Label bsn;
        private Label telNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox employeeShiftLb;
    }
}
