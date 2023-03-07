namespace S2GroupProject
{
	partial class Form1
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
			this.employeesLb = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.AddEmployee = new System.Windows.Forms.Button();
			this.daysOffClb = new System.Windows.Forms.CheckedListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.ageTb = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.wageTb = new System.Windows.Forms.TextBox();
			this.jobPositionCb = new System.Windows.Forms.ComboBox();
			this.hoursPerWeekTb = new System.Windows.Forms.TextBox();
			this.contractCb = new System.Windows.Forms.ComboBox();
			this.addressTb = new System.Windows.Forms.TextBox();
			this.telNumberTb = new System.Windows.Forms.TextBox();
			this.bsnTb = new System.Windows.Forms.TextBox();
			this.lastNameTb = new System.Windows.Forms.TextBox();
			this.firstNameTb = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RemoveBtn = new System.Windows.Forms.Button();
			this.bsnRemoveTb = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// employeesLb
			// 
			this.employeesLb.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.employeesLb.FormattingEnabled = true;
			this.employeesLb.ItemHeight = 22;
			this.employeesLb.Location = new System.Drawing.Point(398, 11);
			this.employeesLb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeesLb.Name = "employeesLb";
			this.employeesLb.Size = new System.Drawing.Size(1028, 466);
			this.employeesLb.TabIndex = 0;
			this.employeesLb.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.AddEmployee);
			this.groupBox1.Controls.Add(this.daysOffClb);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.ageTb);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.wageTb);
			this.groupBox1.Controls.Add(this.jobPositionCb);
			this.groupBox1.Controls.Add(this.hoursPerWeekTb);
			this.groupBox1.Controls.Add(this.contractCb);
			this.groupBox1.Controls.Add(this.addressTb);
			this.groupBox1.Controls.Add(this.telNumberTb);
			this.groupBox1.Controls.Add(this.bsnTb);
			this.groupBox1.Controls.Add(this.lastNameTb);
			this.groupBox1.Controls.Add(this.firstNameTb);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(7, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 466);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// AddEmployee
			// 
			this.AddEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddEmployee.Location = new System.Drawing.Point(207, 400);
			this.AddEmployee.Name = "AddEmployee";
			this.AddEmployee.Size = new System.Drawing.Size(159, 49);
			this.AddEmployee.TabIndex = 22;
			this.AddEmployee.Text = "Add To Management";
			this.AddEmployee.UseVisualStyleBackColor = true;
			this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
			// 
			// daysOffClb
			// 
			this.daysOffClb.FormattingEnabled = true;
			this.daysOffClb.Location = new System.Drawing.Point(72, 345);
			this.daysOffClb.Name = "daysOffClb";
			this.daysOffClb.Size = new System.Drawing.Size(108, 112);
			this.daysOffClb.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 349);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 15);
			this.label11.TabIndex = 20;
			this.label11.Text = "Days Off:";
			// 
			// ageTb
			// 
			this.ageTb.Location = new System.Drawing.Point(104, 298);
			this.ageTb.Name = "ageTb";
			this.ageTb.Size = new System.Drawing.Size(134, 23);
			this.ageTb.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(55, 306);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "Age:";
			// 
			// wageTb
			// 
			this.wageTb.Location = new System.Drawing.Point(104, 266);
			this.wageTb.Name = "wageTb";
			this.wageTb.Size = new System.Drawing.Size(134, 23);
			this.wageTb.TabIndex = 17;
			// 
			// jobPositionCb
			// 
			this.jobPositionCb.FormattingEnabled = true;
			this.jobPositionCb.Location = new System.Drawing.Point(80, 227);
			this.jobPositionCb.Name = "jobPositionCb";
			this.jobPositionCb.Size = new System.Drawing.Size(158, 23);
			this.jobPositionCb.TabIndex = 16;
			// 
			// hoursPerWeekTb
			// 
			this.hoursPerWeekTb.Location = new System.Drawing.Point(148, 198);
			this.hoursPerWeekTb.Name = "hoursPerWeekTb";
			this.hoursPerWeekTb.Size = new System.Drawing.Size(134, 23);
			this.hoursPerWeekTb.TabIndex = 15;
			// 
			// contractCb
			// 
			this.contractCb.FormattingEnabled = true;
			this.contractCb.Location = new System.Drawing.Point(88, 161);
			this.contractCb.Name = "contractCb";
			this.contractCb.Size = new System.Drawing.Size(150, 23);
			this.contractCb.TabIndex = 14;
			// 
			// addressTb
			// 
			this.addressTb.Location = new System.Drawing.Point(75, 129);
			this.addressTb.Name = "addressTb";
			this.addressTb.Size = new System.Drawing.Size(134, 23);
			this.addressTb.TabIndex = 13;
			// 
			// telNumberTb
			// 
			this.telNumberTb.Location = new System.Drawing.Point(75, 100);
			this.telNumberTb.Name = "telNumberTb";
			this.telNumberTb.Size = new System.Drawing.Size(134, 23);
			this.telNumberTb.TabIndex = 12;
			// 
			// bsnTb
			// 
			this.bsnTb.Location = new System.Drawing.Point(75, 74);
			this.bsnTb.Name = "bsnTb";
			this.bsnTb.Size = new System.Drawing.Size(134, 23);
			this.bsnTb.TabIndex = 11;
			// 
			// lastNameTb
			// 
			this.lastNameTb.Location = new System.Drawing.Point(75, 48);
			this.lastNameTb.Name = "lastNameTb";
			this.lastNameTb.Size = new System.Drawing.Size(134, 23);
			this.lastNameTb.TabIndex = 10;
			// 
			// firstNameTb
			// 
			this.firstNameTb.Location = new System.Drawing.Point(75, 22);
			this.firstNameTb.Name = "firstNameTb";
			this.firstNameTb.Size = new System.Drawing.Size(134, 23);
			this.firstNameTb.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 269);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 15);
			this.label9.TabIndex = 8;
			this.label9.Text = "Employee Wage:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(0, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = "Job Position:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(0, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(142, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Working Hours Per Week:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Contract Type:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Address:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tel Number:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "BSN:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RemoveBtn);
			this.groupBox2.Controls.Add(this.bsnRemoveTb);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Location = new System.Drawing.Point(7, 492);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 279);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// RemoveBtn
			// 
			this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RemoveBtn.Location = new System.Drawing.Point(7, 102);
			this.RemoveBtn.Name = "RemoveBtn";
			this.RemoveBtn.Size = new System.Drawing.Size(159, 49);
			this.RemoveBtn.TabIndex = 23;
			this.RemoveBtn.Text = "Remove from Management";
			this.RemoveBtn.UseVisualStyleBackColor = true;
			this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
			// 
			// bsnRemoveTb
			// 
			this.bsnRemoveTb.Location = new System.Drawing.Point(46, 35);
			this.bsnRemoveTb.Name = "bsnRemoveTb";
			this.bsnRemoveTb.Size = new System.Drawing.Size(134, 23);
			this.bsnRemoveTb.TabIndex = 23;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 38);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 15);
			this.label12.TabIndex = 23;
			this.label12.Text = "BSN:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dateTimePicker1);
			this.groupBox3.Location = new System.Drawing.Point(399, 492);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1028, 279);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 38);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1438, 778);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.employeesLb);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox employeesLb;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private TextBox telNumberTb;
		private TextBox bsnTb;
		private TextBox lastNameTb;
		private TextBox firstNameTb;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox wageTb;
		private ComboBox jobPositionCb;
		private TextBox hoursPerWeekTb;
		private ComboBox contractCb;
		private TextBox addressTb;
		private TextBox ageTb;
		private Label label10;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label label11;
		private CheckedListBox daysOffClb;
		private Button AddEmployee;
		private Button RemoveBtn;
		private TextBox bsnRemoveTb;
		private Label label12;
		private DateTimePicker dateTimePicker1;
	}
}