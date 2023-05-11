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
			contractTypeFilterClb = new CheckedListBox();
			shiftDayPickerFilter = new DateTimePicker();
			jobPositionsFilterCb = new ComboBox();
			AddAnEmpBtn = new Button();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// employeesLb
			// 
			employeesLb.BackColor = SystemColors.ButtonHighlight;
			employeesLb.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			employeesLb.FormattingEnabled = true;
			employeesLb.HorizontalScrollbar = true;
			employeesLb.ItemHeight = 35;
			employeesLb.Location = new Point(14, 238);
			employeesLb.Margin = new Padding(4, 3, 4, 3);
			employeesLb.Name = "employeesLb";
			employeesLb.Size = new Size(2020, 529);
			employeesLb.TabIndex = 0;
			employeesLb.Click += listBox1_SelectedIndexChanged;
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
			searchButton.BackColor = SystemColors.ButtonHighlight;
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
			RemoveBtn.BackColor = SystemColors.ButtonHighlight;
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
			addShiftBtn.BackColor = SystemColors.ButtonHighlight;
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
			shiftTypeCb.BackColor = SystemColors.ButtonFace;
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
			createScheduleBtn.BackColor = SystemColors.ButtonHighlight;
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
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(contractTypeFilterClb);
			groupBox4.Controls.Add(shiftDayPickerFilter);
			groupBox4.Controls.Add(jobPositionsFilterCb);
			groupBox4.Location = new Point(407, 18);
			groupBox4.Margin = new Padding(4, 5, 4, 5);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(4, 5, 4, 5);
			groupBox4.Size = new Size(1626, 193);
			groupBox4.TabIndex = 4;
			groupBox4.TabStop = false;
			groupBox4.Text = "Filtering Options";
			// 
			// contractTypeFilterClb
			// 
			contractTypeFilterClb.BackColor = SystemColors.ButtonHighlight;
			contractTypeFilterClb.FormattingEnabled = true;
			contractTypeFilterClb.Location = new Point(1240, 27);
			contractTypeFilterClb.Margin = new Padding(4, 5, 4, 5);
			contractTypeFilterClb.Name = "contractTypeFilterClb";
			contractTypeFilterClb.Size = new Size(331, 144);
			contractTypeFilterClb.TabIndex = 35;
			contractTypeFilterClb.SelectedIndexChanged += contractTypeFilterClb_SelectedIndexChanged;
			// 
			// shiftDayPickerFilter
			// 
			shiftDayPickerFilter.Location = new Point(624, 42);
			shiftDayPickerFilter.Margin = new Padding(4, 5, 4, 5);
			shiftDayPickerFilter.Name = "shiftDayPickerFilter";
			shiftDayPickerFilter.Size = new Size(448, 31);
			shiftDayPickerFilter.TabIndex = 34;
			shiftDayPickerFilter.ValueChanged += shiftDayPickerFilter_ValueChanged;
			// 
			// jobPositionsFilterCb
			// 
			jobPositionsFilterCb.BackColor = SystemColors.ButtonHighlight;
			jobPositionsFilterCb.FormattingEnabled = true;
			jobPositionsFilterCb.Location = new Point(4, 42);
			jobPositionsFilterCb.Margin = new Padding(4, 5, 4, 5);
			jobPositionsFilterCb.Name = "jobPositionsFilterCb";
			jobPositionsFilterCb.Size = new Size(308, 33);
			jobPositionsFilterCb.TabIndex = 0;
			jobPositionsFilterCb.Click += jobPositionsFilterCb_SelectedIndexChanged;
			// 
			// AddAnEmpBtn
			// 
			AddAnEmpBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			AddAnEmpBtn.Location = new Point(20, 20);
			AddAnEmpBtn.Margin = new Padding(4, 5, 4, 5);
			AddAnEmpBtn.Name = "AddAnEmpBtn";
			AddAnEmpBtn.Size = new Size(379, 210);
			AddAnEmpBtn.TabIndex = 5;
			AddAnEmpBtn.Text = "Add an Employee";
			AddAnEmpBtn.UseVisualStyleBackColor = true;
			AddAnEmpBtn.Click += AddAnEmpBtn_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1924, 1050);
			Controls.Add(AddAnEmpBtn);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(employeesLb);
			Margin = new Padding(4, 3, 4, 3);
			Name = "MainPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainPage";
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			ResumeLayout(false);
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
		private Button AddAnEmpBtn;
	}
}