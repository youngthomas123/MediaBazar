namespace S2GroupProject
{
    partial class MainPage
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
            ShowEmployees = new Button();
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
            monthLb = new Label();
            groupBox2 = new GroupBox();
            searchButton = new Button();
            RemoveBtn = new Button();
            searchTB = new TextBox();
            bsnRemoveTb = new TextBox();
            label13 = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            addShiftBtn = new Button();
            shiftBsnTb = new TextBox();
            label21 = new Label();
            shiftTypeCb = new ComboBox();
            shiftDayPicker = new DateTimePicker();
            createScheduleBtn = new Button();
            button2 = new Button();
            button1 = new Button();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox4 = new GroupBox();
            SeeItemsButton = new Button();
            contractTypeFilterClb = new CheckedListBox();
            shiftDayPickerFilter = new DateTimePicker();
            jobPositionsFilterCb = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // employeesLb
            // 
            employeesLb.BackColor = Color.Moccasin;
            employeesLb.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            employeesLb.FormattingEnabled = true;
            employeesLb.ItemHeight = 35;
            employeesLb.Location = new Point(569, 238);
            employeesLb.Margin = new Padding(4, 3, 4, 3);
            employeesLb.Name = "employeesLb";
            employeesLb.Size = new Size(1467, 494);
            employeesLb.TabIndex = 0;
            employeesLb.SelectedIndexChanged += employeesLb_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ShowEmployees);
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
            groupBox1.Text = "Add Employee";
            // 
            // ShowEmployees
            // 
            ShowEmployees.BackColor = Color.LimeGreen;
            ShowEmployees.Location = new Point(296, 610);
            ShowEmployees.Margin = new Padding(4, 5, 4, 5);
            ShowEmployees.Name = "ShowEmployees";
            ShowEmployees.Size = new Size(227, 47);
            ShowEmployees.TabIndex = 25;
            ShowEmployees.Text = "Show all";
            ShowEmployees.UseVisualStyleBackColor = false;
            ShowEmployees.Click += ShowEmployees_Click;
            // 
            // AddEmployee
            // 
            AddEmployee.BackColor = Color.DeepSkyBlue;
            AddEmployee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmployee.Location = new Point(296, 667);
            AddEmployee.Margin = new Padding(4, 5, 4, 5);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(227, 82);
            AddEmployee.TabIndex = 22;
            AddEmployee.Text = "Add To Management";
            AddEmployee.UseVisualStyleBackColor = false;
            AddEmployee.Click += AddEmployee_Click;
            // 
            // daysOffClb
            // 
            daysOffClb.BackColor = Color.Moccasin;
            daysOffClb.FormattingEnabled = true;
            daysOffClb.Location = new Point(103, 575);
            daysOffClb.Margin = new Padding(4, 5, 4, 5);
            daysOffClb.Name = "daysOffClb";
            daysOffClb.Size = new Size(153, 116);
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
            ageTb.BackColor = SystemColors.ButtonHighlight;
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
            wageTb.BackColor = SystemColors.ButtonHighlight;
            wageTb.Location = new Point(149, 443);
            wageTb.Margin = new Padding(4, 5, 4, 5);
            wageTb.Name = "wageTb";
            wageTb.Size = new Size(190, 31);
            wageTb.TabIndex = 17;
            // 
            // jobPositionCb
            // 
            jobPositionCb.BackColor = SystemColors.ButtonHighlight;
            jobPositionCb.FormattingEnabled = true;
            jobPositionCb.Location = new Point(114, 378);
            jobPositionCb.Margin = new Padding(4, 5, 4, 5);
            jobPositionCb.Name = "jobPositionCb";
            jobPositionCb.Size = new Size(224, 33);
            jobPositionCb.TabIndex = 16;
            // 
            // hoursPerWeekTb
            // 
            hoursPerWeekTb.BackColor = SystemColors.ButtonHighlight;
            hoursPerWeekTb.Location = new Point(211, 330);
            hoursPerWeekTb.Margin = new Padding(4, 5, 4, 5);
            hoursPerWeekTb.Name = "hoursPerWeekTb";
            hoursPerWeekTb.Size = new Size(190, 31);
            hoursPerWeekTb.TabIndex = 15;
            // 
            // contractCb
            // 
            contractCb.BackColor = SystemColors.ButtonHighlight;
            contractCb.FormattingEnabled = true;
            contractCb.Location = new Point(126, 268);
            contractCb.Margin = new Padding(4, 5, 4, 5);
            contractCb.Name = "contractCb";
            contractCb.Size = new Size(213, 33);
            contractCb.TabIndex = 14;
            // 
            // addressTb
            // 
            addressTb.BackColor = SystemColors.ButtonHighlight;
            addressTb.Location = new Point(107, 215);
            addressTb.Margin = new Padding(4, 5, 4, 5);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(190, 31);
            addressTb.TabIndex = 13;
            // 
            // telNumberTb
            // 
            telNumberTb.BackColor = SystemColors.ButtonHighlight;
            telNumberTb.Location = new Point(107, 167);
            telNumberTb.Margin = new Padding(4, 5, 4, 5);
            telNumberTb.Name = "telNumberTb";
            telNumberTb.Size = new Size(190, 31);
            telNumberTb.TabIndex = 12;
            // 
            // bsnTb
            // 
            bsnTb.BackColor = SystemColors.ButtonHighlight;
            bsnTb.Location = new Point(107, 123);
            bsnTb.Margin = new Padding(4, 5, 4, 5);
            bsnTb.Name = "bsnTb";
            bsnTb.Size = new Size(190, 31);
            bsnTb.TabIndex = 11;
            // 
            // lastNameTb
            // 
            lastNameTb.BackColor = SystemColors.ButtonHighlight;
            lastNameTb.Location = new Point(107, 80);
            lastNameTb.Margin = new Padding(4, 5, 4, 5);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(190, 31);
            lastNameTb.TabIndex = 10;
            // 
            // firstNameTb
            // 
            firstNameTb.BackColor = SystemColors.ButtonHighlight;
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
            // monthLb
            // 
            monthLb.AutoSize = true;
            monthLb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            monthLb.Location = new Point(40, 313);
            monthLb.Margin = new Padding(4, 0, 4, 0);
            monthLb.Name = "monthLb";
            monthLb.Size = new Size(0, 31);
            monthLb.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(searchButton);
            groupBox2.Controls.Add(RemoveBtn);
            groupBox2.Controls.Add(searchTB);
            groupBox2.Controls.Add(bsnRemoveTb);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(10, 820);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(539, 465);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete Employee";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.LimeGreen;
            searchButton.Location = new Point(144, 348);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(191, 47);
            searchButton.TabIndex = 24;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.IndianRed;
            RemoveBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBtn.ForeColor = SystemColors.ControlText;
            RemoveBtn.Location = new Point(10, 170);
            RemoveBtn.Margin = new Padding(4, 5, 4, 5);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(227, 82);
            RemoveBtn.TabIndex = 23;
            RemoveBtn.Text = "Remove from Management";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // searchTB
            // 
            searchTB.BackColor = SystemColors.ButtonHighlight;
            searchTB.Location = new Point(144, 300);
            searchTB.Margin = new Padding(4, 5, 4, 5);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(190, 31);
            searchTB.TabIndex = 23;
            // 
            // bsnRemoveTb
            // 
            bsnRemoveTb.BackColor = SystemColors.ButtonHighlight;
            bsnRemoveTb.Location = new Point(66, 58);
            bsnRemoveTb.Margin = new Padding(4, 5, 4, 5);
            bsnRemoveTb.Name = "bsnRemoveTb";
            bsnRemoveTb.Size = new Size(190, 31);
            bsnRemoveTb.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 307);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(133, 25);
            label13.TabIndex = 0;
            label13.Text = "Search via BSN:";
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
            groupBox3.Controls.Add(addShiftBtn);
            groupBox3.Controls.Add(shiftBsnTb);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(shiftTypeCb);
            groupBox3.Controls.Add(shiftDayPicker);
            groupBox3.Controls.Add(createScheduleBtn);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(monthLb);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Location = new Point(570, 820);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(1469, 465);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Schedule Shifts";
            // 
            // addShiftBtn
            // 
            addShiftBtn.BackColor = Color.LimeGreen;
            addShiftBtn.Location = new Point(920, 380);
            addShiftBtn.Margin = new Padding(4, 5, 4, 5);
            addShiftBtn.Name = "addShiftBtn";
            addShiftBtn.Size = new Size(191, 47);
            addShiftBtn.TabIndex = 25;
            addShiftBtn.Text = "Add Shift";
            addShiftBtn.UseVisualStyleBackColor = false;
            addShiftBtn.Click += addShiftBtn_Click;
            // 
            // shiftBsnTb
            // 
            shiftBsnTb.BackColor = SystemColors.ButtonHighlight;
            shiftBsnTb.Location = new Point(670, 380);
            shiftBsnTb.Margin = new Padding(4, 5, 4, 5);
            shiftBsnTb.Name = "shiftBsnTb";
            shiftBsnTb.Size = new Size(190, 31);
            shiftBsnTb.TabIndex = 33;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(616, 385);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(49, 25);
            label21.TabIndex = 32;
            label21.Text = "BSN:";
            // 
            // shiftTypeCb
            // 
            shiftTypeCb.BackColor = Color.Moccasin;
            shiftTypeCb.FormattingEnabled = true;
            shiftTypeCb.Location = new Point(387, 380);
            shiftTypeCb.Margin = new Padding(4, 5, 4, 5);
            shiftTypeCb.Name = "shiftTypeCb";
            shiftTypeCb.Size = new Size(194, 33);
            shiftTypeCb.TabIndex = 31;
            // 
            // shiftDayPicker
            // 
            shiftDayPicker.CalendarForeColor = Color.Moccasin;
            shiftDayPicker.CalendarMonthBackground = Color.Moccasin;
            shiftDayPicker.CalendarTitleBackColor = Color.Moccasin;
            shiftDayPicker.Location = new Point(387, 318);
            shiftDayPicker.Margin = new Padding(4, 5, 4, 5);
            shiftDayPicker.Name = "shiftDayPicker";
            shiftDayPicker.Size = new Size(448, 31);
            shiftDayPicker.TabIndex = 30;
            // 
            // createScheduleBtn
            // 
            createScheduleBtn.BackColor = Color.DeepSkyBlue;
            createScheduleBtn.Location = new Point(120, 390);
            createScheduleBtn.Margin = new Padding(4, 5, 4, 5);
            createScheduleBtn.Name = "createScheduleBtn";
            createScheduleBtn.Size = new Size(186, 60);
            createScheduleBtn.TabIndex = 29;
            createScheduleBtn.Text = "Create Schedule";
            createScheduleBtn.UseVisualStyleBackColor = false;
            createScheduleBtn.Click += createScheduleBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1439, 148);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(29, 42);
            button2.TabIndex = 28;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(6, 148);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(29, 42);
            button1.TabIndex = 27;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(1063, 25);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(104, 31);
            label20.TabIndex = 7;
            label20.Text = "Saturday";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(883, 25);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(76, 31);
            label19.TabIndex = 6;
            label19.Text = "Friday";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(670, 25);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(107, 31);
            label18.TabIndex = 5;
            label18.Text = "Thursday";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(461, 25);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(132, 31);
            label17.TabIndex = 4;
            label17.Text = "Wednesday";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(281, 25);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(98, 31);
            label16.TabIndex = 3;
            label16.Text = "Tuesday";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(104, 30);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(98, 31);
            label15.TabIndex = 2;
            label15.Text = "Monday";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1236, 30);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(89, 31);
            label14.TabIndex = 1;
            label14.Text = "Sunday";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(40, 63);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1400, 233);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(SeeItemsButton);
            groupBox4.Controls.Add(contractTypeFilterClb);
            groupBox4.Controls.Add(shiftDayPickerFilter);
            groupBox4.Controls.Add(jobPositionsFilterCb);
            groupBox4.Location = new Point(566, 18);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1467, 193);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filtering Options";
            // 
            // SeeItemsButton
            // 
            SeeItemsButton.BackColor = Color.LimeGreen;
            SeeItemsButton.Location = new Point(909, 37);
            SeeItemsButton.Name = "SeeItemsButton";
            SeeItemsButton.Size = new Size(221, 50);
            SeeItemsButton.TabIndex = 36;
            SeeItemsButton.Text = "See Items";
            SeeItemsButton.UseVisualStyleBackColor = false;
            SeeItemsButton.Click += SeeItemsButton_Click;
            // 
            // contractTypeFilterClb
            // 
            contractTypeFilterClb.BackColor = Color.Moccasin;
            contractTypeFilterClb.FormattingEnabled = true;
            contractTypeFilterClb.Location = new Point(1240, 27);
            contractTypeFilterClb.Margin = new Padding(4, 5, 4, 5);
            contractTypeFilterClb.Name = "contractTypeFilterClb";
            contractTypeFilterClb.Size = new Size(213, 116);
            contractTypeFilterClb.TabIndex = 35;
            contractTypeFilterClb.SelectedIndexChanged += contractTypeFilterClb_SelectedIndexChanged;
            // 
            // shiftDayPickerFilter
            // 
            shiftDayPickerFilter.Location = new Point(354, 42);
            shiftDayPickerFilter.Margin = new Padding(4, 5, 4, 5);
            shiftDayPickerFilter.Name = "shiftDayPickerFilter";
            shiftDayPickerFilter.Size = new Size(448, 31);
            shiftDayPickerFilter.TabIndex = 34;
            shiftDayPickerFilter.ValueChanged += shiftDayPickerFilter_ValueChanged;
            // 
            // jobPositionsFilterCb
            // 
            jobPositionsFilterCb.BackColor = Color.Moccasin;
            jobPositionsFilterCb.FormattingEnabled = true;
            jobPositionsFilterCb.Location = new Point(4, 42);
            jobPositionsFilterCb.Margin = new Padding(4, 5, 4, 5);
            jobPositionsFilterCb.Name = "jobPositionsFilterCb";
            jobPositionsFilterCb.Size = new Size(308, 33);
            jobPositionsFilterCb.TabIndex = 0;
            jobPositionsFilterCb.SelectedIndexChanged += jobPositionsFilterCb_SelectedIndexChanged;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1924, 1050);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(employeesLb);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
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
        private Button ShowEmployees;
        private Button searchButton;
        private TextBox searchTB;
        private Label label13;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label monthLb;
        private Button button2;
        private Button button1;
        private Button createScheduleBtn;
        private DateTimePicker shiftDayPicker;
        private Button addShiftBtn;
        private TextBox shiftBsnTb;
        private Label label21;
        private ComboBox shiftTypeCb;
        private GroupBox groupBox4;
        private ComboBox jobPositionsFilterCb;
        private DateTimePicker shiftDayPickerFilter;
        private CheckedListBox contractTypeFilterClb;
        private Button SeeItemsButton;
    }
}