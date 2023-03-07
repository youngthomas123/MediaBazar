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
            employeesLb = new ListBox();
            groupBox1 = new GroupBox();
            AddEmployee = new Button();
            daysOffClb = new CheckedListBox();
            label11 = new Label();
            ageTb = new TextBox();
            label10 = new Label();
            wageTb = new TextBox();
            jobPositionCb = new ComboBox();
            hoursPerWeekTb = new TextBox();
            contractCb = new ComboBox();
            addressTb = new TextBox();
            telNumberTb = new TextBox();
            bsnTb = new TextBox();
            lastNameTb = new TextBox();
            firstNameTb = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            RemoveBtn = new Button();
            bsnRemoveTb = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // employeesLb
            // 
            employeesLb.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            employeesLb.FormattingEnabled = true;
            employeesLb.ItemHeight = 35;
            employeesLb.Location = new Point(569, 18);
            employeesLb.Margin = new Padding(4, 3, 4, 3);
            employeesLb.Name = "employeesLb";
            employeesLb.Size = new Size(1467, 774);
            employeesLb.TabIndex = 0;
            employeesLb.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddEmployee);
            groupBox1.Controls.Add(daysOffClb);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(ageTb);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(wageTb);
            groupBox1.Controls.Add(jobPositionCb);
            groupBox1.Controls.Add(hoursPerWeekTb);
            groupBox1.Controls.Add(contractCb);
            groupBox1.Controls.Add(addressTb);
            groupBox1.Controls.Add(telNumberTb);
            groupBox1.Controls.Add(bsnTb);
            groupBox1.Controls.Add(lastNameTb);
            groupBox1.Controls.Add(firstNameTb);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 18);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(539, 777);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // AddEmployee
            // 
            AddEmployee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmployee.Location = new Point(296, 667);
            AddEmployee.Margin = new Padding(4, 5, 4, 5);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(227, 82);
            AddEmployee.TabIndex = 22;
            AddEmployee.Text = "Add To Management";
            AddEmployee.UseVisualStyleBackColor = true;
            AddEmployee.Click += AddEmployee_Click;
            // 
            // daysOffClb
            // 
            daysOffClb.FormattingEnabled = true;
            daysOffClb.Location = new Point(103, 575);
            daysOffClb.Margin = new Padding(4, 5, 4, 5);
            daysOffClb.Name = "daysOffClb";
            daysOffClb.Size = new Size(153, 172);
            daysOffClb.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 582);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 25);
            label11.TabIndex = 20;
            label11.Text = "Days Off:";
            // 
            // ageTb
            // 
            ageTb.Location = new Point(149, 497);
            ageTb.Margin = new Padding(4, 5, 4, 5);
            ageTb.Name = "ageTb";
            ageTb.Size = new Size(190, 31);
            ageTb.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(79, 510);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 25);
            label10.TabIndex = 18;
            label10.Text = "Age:";
            // 
            // wageTb
            // 
            wageTb.Location = new Point(149, 443);
            wageTb.Margin = new Padding(4, 5, 4, 5);
            wageTb.Name = "wageTb";
            wageTb.Size = new Size(190, 31);
            wageTb.TabIndex = 17;
            // 
            // jobPositionCb
            // 
            jobPositionCb.FormattingEnabled = true;
            jobPositionCb.Location = new Point(114, 378);
            jobPositionCb.Margin = new Padding(4, 5, 4, 5);
            jobPositionCb.Name = "jobPositionCb";
            jobPositionCb.Size = new Size(224, 33);
            jobPositionCb.TabIndex = 16;
            // 
            // hoursPerWeekTb
            // 
            hoursPerWeekTb.Location = new Point(211, 330);
            hoursPerWeekTb.Margin = new Padding(4, 5, 4, 5);
            hoursPerWeekTb.Name = "hoursPerWeekTb";
            hoursPerWeekTb.Size = new Size(190, 31);
            hoursPerWeekTb.TabIndex = 15;
            hoursPerWeekTb.TextChanged += hoursPerWeekTb_TextChanged;
            // 
            // contractCb
            // 
            contractCb.FormattingEnabled = true;
            contractCb.Location = new Point(126, 268);
            contractCb.Margin = new Padding(4, 5, 4, 5);
            contractCb.Name = "contractCb";
            contractCb.Size = new Size(213, 33);
            contractCb.TabIndex = 14;
            // 
            // addressTb
            // 
            addressTb.Location = new Point(107, 215);
            addressTb.Margin = new Padding(4, 5, 4, 5);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(190, 31);
            addressTb.TabIndex = 13;
            // 
            // telNumberTb
            // 
            telNumberTb.Location = new Point(107, 167);
            telNumberTb.Margin = new Padding(4, 5, 4, 5);
            telNumberTb.Name = "telNumberTb";
            telNumberTb.Size = new Size(190, 31);
            telNumberTb.TabIndex = 12;
            // 
            // bsnTb
            // 
            bsnTb.Location = new Point(107, 123);
            bsnTb.Margin = new Padding(4, 5, 4, 5);
            bsnTb.Name = "bsnTb";
            bsnTb.Size = new Size(190, 31);
            bsnTb.TabIndex = 11;
            // 
            // lastNameTb
            // 
            lastNameTb.Location = new Point(107, 80);
            lastNameTb.Margin = new Padding(4, 5, 4, 5);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(190, 31);
            lastNameTb.TabIndex = 10;
            // 
            // firstNameTb
            // 
            firstNameTb.Location = new Point(107, 37);
            firstNameTb.Margin = new Padding(4, 5, 4, 5);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.Size = new Size(190, 31);
            firstNameTb.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 448);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 25);
            label9.TabIndex = 8;
            label9.Text = "Employee Wage:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 385);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 7;
            label8.Text = "Job Position:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 335);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(213, 25);
            label7.TabIndex = 6;
            label7.Text = "Working Hours Per Week:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 273);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Contract Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 225);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 172);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Tel Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 123);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "BSN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RemoveBtn);
            groupBox2.Controls.Add(bsnRemoveTb);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(10, 820);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(539, 465);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // RemoveBtn
            // 
            RemoveBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBtn.Location = new Point(10, 170);
            RemoveBtn.Margin = new Padding(4, 5, 4, 5);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(227, 82);
            RemoveBtn.TabIndex = 23;
            RemoveBtn.Text = "Remove from Management";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // bsnRemoveTb
            // 
            bsnRemoveTb.Location = new Point(66, 58);
            bsnRemoveTb.Margin = new Padding(4, 5, 4, 5);
            bsnRemoveTb.Name = "bsnRemoveTb";
            bsnRemoveTb.Size = new Size(190, 31);
            bsnRemoveTb.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 63);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 23;
            label12.Text = "BSN:";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(570, 820);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(1469, 465);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(employeesLb);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
    }
}