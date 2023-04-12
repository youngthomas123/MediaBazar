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
			this.employeesLb = new System.Windows.Forms.ListBox();
			this.monthLb = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.RemoveBtn = new System.Windows.Forms.Button();
			this.searchTB = new System.Windows.Forms.TextBox();
			this.bsnRemoveTb = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.addShiftBtn = new System.Windows.Forms.Button();
			this.shiftBsnTb = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.shiftTypeCb = new System.Windows.Forms.ComboBox();
			this.shiftDayPicker = new System.Windows.Forms.DateTimePicker();
			this.createScheduleBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.SeeItemsButton = new System.Windows.Forms.Button();
			this.contractTypeFilterClb = new System.Windows.Forms.CheckedListBox();
			this.shiftDayPickerFilter = new System.Windows.Forms.DateTimePicker();
			this.jobPositionsFilterCb = new System.Windows.Forms.ComboBox();
			this.AddAnEmpBtn = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// employeesLb
			// 
			this.employeesLb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.employeesLb.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.employeesLb.FormattingEnabled = true;
			this.employeesLb.ItemHeight = 22;
			this.employeesLb.Location = new System.Drawing.Point(10, 143);
			this.employeesLb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.employeesLb.Name = "employeesLb";
			this.employeesLb.Size = new System.Drawing.Size(1415, 334);
			this.employeesLb.TabIndex = 0;
			this.employeesLb.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// monthLb
			// 
			this.monthLb.AutoSize = true;
			this.monthLb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.monthLb.Location = new System.Drawing.Point(28, 188);
			this.monthLb.Name = "monthLb";
			this.monthLb.Size = new System.Drawing.Size(0, 20);
			this.monthLb.TabIndex = 26;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.searchButton);
			this.groupBox2.Controls.Add(this.RemoveBtn);
			this.groupBox2.Controls.Add(this.searchTB);
			this.groupBox2.Controls.Add(this.bsnRemoveTb);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Location = new System.Drawing.Point(7, 492);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 279);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Delete Employee";
			// 
			// searchButton
			// 
			this.searchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.searchButton.Location = new System.Drawing.Point(101, 209);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(134, 28);
			this.searchButton.TabIndex = 24;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// RemoveBtn
			// 
			this.RemoveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RemoveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RemoveBtn.Location = new System.Drawing.Point(7, 102);
			this.RemoveBtn.Name = "RemoveBtn";
			this.RemoveBtn.Size = new System.Drawing.Size(159, 49);
			this.RemoveBtn.TabIndex = 23;
			this.RemoveBtn.Text = "Remove from Management";
			this.RemoveBtn.UseVisualStyleBackColor = false;
			this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
			// 
			// searchTB
			// 
			this.searchTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.searchTB.Location = new System.Drawing.Point(101, 180);
			this.searchTB.Name = "searchTB";
			this.searchTB.Size = new System.Drawing.Size(134, 23);
			this.searchTB.TabIndex = 23;
			// 
			// bsnRemoveTb
			// 
			this.bsnRemoveTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bsnRemoveTb.Location = new System.Drawing.Point(46, 35);
			this.bsnRemoveTb.Name = "bsnRemoveTb";
			this.bsnRemoveTb.Size = new System.Drawing.Size(134, 23);
			this.bsnRemoveTb.TabIndex = 23;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 184);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(88, 15);
			this.label13.TabIndex = 0;
			this.label13.Text = "Search via BSN:";
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
			this.groupBox3.Controls.Add(this.addShiftBtn);
			this.groupBox3.Controls.Add(this.shiftBsnTb);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.shiftTypeCb);
			this.groupBox3.Controls.Add(this.shiftDayPicker);
			this.groupBox3.Controls.Add(this.createScheduleBtn);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.monthLb);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.flowLayoutPanel1);
			this.groupBox3.Location = new System.Drawing.Point(399, 492);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1028, 279);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Schedule Shifts";
			// 
			// addShiftBtn
			// 
			this.addShiftBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addShiftBtn.Location = new System.Drawing.Point(644, 228);
			this.addShiftBtn.Name = "addShiftBtn";
			this.addShiftBtn.Size = new System.Drawing.Size(134, 28);
			this.addShiftBtn.TabIndex = 25;
			this.addShiftBtn.Text = "Add Shift";
			this.addShiftBtn.UseVisualStyleBackColor = false;
			this.addShiftBtn.Click += new System.EventHandler(this.addShiftBtn_Click);
			// 
			// shiftBsnTb
			// 
			this.shiftBsnTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.shiftBsnTb.Location = new System.Drawing.Point(469, 228);
			this.shiftBsnTb.Name = "shiftBsnTb";
			this.shiftBsnTb.Size = new System.Drawing.Size(134, 23);
			this.shiftBsnTb.TabIndex = 33;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(431, 231);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(32, 15);
			this.label21.TabIndex = 32;
			this.label21.Text = "BSN:";
			// 
			// shiftTypeCb
			// 
			this.shiftTypeCb.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.shiftTypeCb.FormattingEnabled = true;
			this.shiftTypeCb.Location = new System.Drawing.Point(271, 228);
			this.shiftTypeCb.Name = "shiftTypeCb";
			this.shiftTypeCb.Size = new System.Drawing.Size(137, 23);
			this.shiftTypeCb.TabIndex = 31;
			// 
			// shiftDayPicker
			// 
			this.shiftDayPicker.CalendarForeColor = System.Drawing.Color.Moccasin;
			this.shiftDayPicker.CalendarMonthBackground = System.Drawing.Color.Moccasin;
			this.shiftDayPicker.CalendarTitleBackColor = System.Drawing.Color.Moccasin;
			this.shiftDayPicker.Location = new System.Drawing.Point(271, 191);
			this.shiftDayPicker.Name = "shiftDayPicker";
			this.shiftDayPicker.Size = new System.Drawing.Size(315, 23);
			this.shiftDayPicker.TabIndex = 30;
			// 
			// createScheduleBtn
			// 
			this.createScheduleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.createScheduleBtn.Location = new System.Drawing.Point(84, 234);
			this.createScheduleBtn.Name = "createScheduleBtn";
			this.createScheduleBtn.Size = new System.Drawing.Size(130, 36);
			this.createScheduleBtn.TabIndex = 29;
			this.createScheduleBtn.Text = "Create Schedule";
			this.createScheduleBtn.UseVisualStyleBackColor = false;
			this.createScheduleBtn.Click += new System.EventHandler(this.createScheduleBtn_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1007, 89);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 25);
			this.button2.TabIndex = 28;
			this.button2.Text = ">";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(4, 89);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 25);
			this.button1.TabIndex = 27;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label20.Location = new System.Drawing.Point(744, 15);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(67, 20);
			this.label20.TabIndex = 7;
			this.label20.Text = "Saturday";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label19.Location = new System.Drawing.Point(618, 15);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(49, 20);
			this.label19.TabIndex = 6;
			this.label19.Text = "Friday";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label18.Location = new System.Drawing.Point(469, 15);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 20);
			this.label18.TabIndex = 5;
			this.label18.Text = "Thursday";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label17.Location = new System.Drawing.Point(323, 15);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(85, 20);
			this.label17.TabIndex = 4;
			this.label17.Text = "Wednesday";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label16.Location = new System.Drawing.Point(197, 15);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(63, 20);
			this.label16.TabIndex = 3;
			this.label16.Text = "Tuesday";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label15.Location = new System.Drawing.Point(73, 18);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(63, 20);
			this.label15.TabIndex = 2;
			this.label15.Text = "Monday";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label14.Location = new System.Drawing.Point(865, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(57, 20);
			this.label14.TabIndex = 1;
			this.label14.Text = "Sunday";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 38);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 140);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.SeeItemsButton);
			this.groupBox4.Controls.Add(this.contractTypeFilterClb);
			this.groupBox4.Controls.Add(this.shiftDayPickerFilter);
			this.groupBox4.Controls.Add(this.jobPositionsFilterCb);
			this.groupBox4.Location = new System.Drawing.Point(285, 11);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1138, 116);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Filtering Options";
			// 
			// SeeItemsButton
			// 
			this.SeeItemsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SeeItemsButton.Location = new System.Drawing.Point(636, 22);
			this.SeeItemsButton.Margin = new System.Windows.Forms.Padding(2);
			this.SeeItemsButton.Name = "SeeItemsButton";
			this.SeeItemsButton.Size = new System.Drawing.Size(155, 30);
			this.SeeItemsButton.TabIndex = 36;
			this.SeeItemsButton.Text = "See Items";
			this.SeeItemsButton.UseVisualStyleBackColor = false;
			// 
			// contractTypeFilterClb
			// 
			this.contractTypeFilterClb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.contractTypeFilterClb.FormattingEnabled = true;
			this.contractTypeFilterClb.Location = new System.Drawing.Point(868, 16);
			this.contractTypeFilterClb.Name = "contractTypeFilterClb";
			this.contractTypeFilterClb.Size = new System.Drawing.Size(233, 94);
			this.contractTypeFilterClb.TabIndex = 35;
			// 
			// shiftDayPickerFilter
			// 
			this.shiftDayPickerFilter.Location = new System.Drawing.Point(248, 25);
			this.shiftDayPickerFilter.Name = "shiftDayPickerFilter";
			this.shiftDayPickerFilter.Size = new System.Drawing.Size(315, 23);
			this.shiftDayPickerFilter.TabIndex = 34;
			// 
			// jobPositionsFilterCb
			// 
			this.jobPositionsFilterCb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.jobPositionsFilterCb.FormattingEnabled = true;
			this.jobPositionsFilterCb.Location = new System.Drawing.Point(3, 25);
			this.jobPositionsFilterCb.Name = "jobPositionsFilterCb";
			this.jobPositionsFilterCb.Size = new System.Drawing.Size(217, 23);
			this.jobPositionsFilterCb.TabIndex = 0;
			// 
			// AddAnEmpBtn
			// 
			this.AddAnEmpBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddAnEmpBtn.Location = new System.Drawing.Point(14, 12);
			this.AddAnEmpBtn.Name = "AddAnEmpBtn";
			this.AddAnEmpBtn.Size = new System.Drawing.Size(265, 126);
			this.AddAnEmpBtn.TabIndex = 5;
			this.AddAnEmpBtn.Text = "Add an Employee";
			this.AddAnEmpBtn.UseVisualStyleBackColor = true;
			this.AddAnEmpBtn.Click += new System.EventHandler(this.AddAnEmpBtn_Click);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1483, 787);
			this.Controls.Add(this.AddAnEmpBtn);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.employeesLb);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainPage";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private ListBox employeesLb;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button RemoveBtn;
        private TextBox bsnRemoveTb;
        private Label label12;
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
        private Button AddAnEmpBtn;
    }
}