namespace S2GroupProject.Forms
{
	partial class WarehouseManager
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			radioButton2 = new RadioButton();
			WarehouseEmployeeRBT = new RadioButton();
			radioButton1 = new RadioButton();
			DeleteItemsRBT = new RadioButton();
			CreateItemsRBT = new RadioButton();
			ItemOverviewRBT = new RadioButton();
			panel2 = new Panel();
			label1 = new Label();
			tabControl1 = new TabControl();
			WarehouseOverview = new TabPage();
			WarehouseItemRestocking = new ListBox();
			ShopRequests = new ListBox();
			groupBox2 = new GroupBox();
			button2 = new Button();
			Restock = new Button();
			ViewItemsBTN = new Button();
			label11 = new Label();
			RefreshDataBTN = new Button();
			Add = new Button();
			warehouseListbox = new ListBox();
			ItemOverview = new TabPage();
			groupBox3 = new GroupBox();
			warehouseComboBox = new ComboBox();
			AssignItemBTN = new Button();
			label12 = new Label();
			groupBox1 = new GroupBox();
			textBox10 = new TextBox();
			label15 = new Label();
			button1 = new Button();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			textBox6 = new TextBox();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			label7 = new Label();
			SearchItembyName = new Button();
			textBox1 = new TextBox();
			label2 = new Label();
			ItemListBox = new ListBox();
			ShowAllItems = new Button();
			CreateItems = new TabPage();
			textBox9 = new TextBox();
			label14 = new Label();
			quantityTB = new TextBox();
			label13 = new Label();
			button3 = new Button();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			DeleteItems = new TabPage();
			button5 = new Button();
			button4 = new Button();
			textBox5 = new TextBox();
			label6 = new Label();
			listBox1 = new ListBox();
			WarehouseEmployees = new TabPage();
			groupBox5 = new GroupBox();
			SearchForEmployeesBTN = new Button();
			label17 = new Label();
			textBox11 = new TextBox();
			groupBox4 = new GroupBox();
			warehouseComboBox2 = new ComboBox();
			AssignEmployeeToWarehouseBTN = new Button();
			label16 = new Label();
			employeeList = new ListBox();
			groupBox6 = new GroupBox();
			ShowWarehouseEmployeesBTN = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tabControl1.SuspendLayout();
			WarehouseOverview.SuspendLayout();
			groupBox2.SuspendLayout();
			ItemOverview.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox1.SuspendLayout();
			CreateItems.SuspendLayout();
			DeleteItems.SuspendLayout();
			WarehouseEmployees.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox6.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(radioButton2);
			panel1.Controls.Add(WarehouseEmployeeRBT);
			panel1.Controls.Add(radioButton1);
			panel1.Controls.Add(DeleteItemsRBT);
			panel1.Controls.Add(CreateItemsRBT);
			panel1.Controls.Add(ItemOverviewRBT);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(2);
			panel1.Name = "panel1";
			panel1.Size = new Size(316, 571);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// radioButton2
			// 
			radioButton2.Appearance = Appearance.Button;
			radioButton2.Location = new Point(2, 522);
			radioButton2.Margin = new Padding(2);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(314, 47);
			radioButton2.TabIndex = 6;
			radioButton2.Text = "Log out";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// WarehouseEmployeeRBT
			// 
			WarehouseEmployeeRBT.Appearance = Appearance.Button;
			WarehouseEmployeeRBT.Location = new Point(-1, 236);
			WarehouseEmployeeRBT.Margin = new Padding(2);
			WarehouseEmployeeRBT.Name = "WarehouseEmployeeRBT";
			WarehouseEmployeeRBT.Size = new Size(316, 47);
			WarehouseEmployeeRBT.TabIndex = 5;
			WarehouseEmployeeRBT.Text = "Warehouse Employees";
			WarehouseEmployeeRBT.UseVisualStyleBackColor = true;
			WarehouseEmployeeRBT.CheckedChanged += WarehouseEmployeeRBT_CheckedChanged;
			// 
			// radioButton1
			// 
			radioButton1.Appearance = Appearance.Button;
			radioButton1.Location = new Point(-1, 59);
			radioButton1.Margin = new Padding(2);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(316, 47);
			radioButton1.TabIndex = 4;
			radioButton1.Text = "Warehouse Overview";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// DeleteItemsRBT
			// 
			DeleteItemsRBT.Appearance = Appearance.Button;
			DeleteItemsRBT.Location = new Point(-1, 146);
			DeleteItemsRBT.Margin = new Padding(2);
			DeleteItemsRBT.Name = "DeleteItemsRBT";
			DeleteItemsRBT.Size = new Size(316, 47);
			DeleteItemsRBT.TabIndex = 2;
			DeleteItemsRBT.Text = "Delete Items";
			DeleteItemsRBT.UseVisualStyleBackColor = true;
			DeleteItemsRBT.CheckedChanged += DeleteItemsRBT_CheckedChanged;
			// 
			// CreateItemsRBT
			// 
			CreateItemsRBT.Appearance = Appearance.Button;
			CreateItemsRBT.Location = new Point(0, 191);
			CreateItemsRBT.Margin = new Padding(2);
			CreateItemsRBT.Name = "CreateItemsRBT";
			CreateItemsRBT.Size = new Size(316, 47);
			CreateItemsRBT.TabIndex = 1;
			CreateItemsRBT.Text = "Create Items";
			CreateItemsRBT.UseVisualStyleBackColor = true;
			CreateItemsRBT.CheckedChanged += CreateItemsRBT_CheckedChanged;
			// 
			// ItemOverviewRBT
			// 
			ItemOverviewRBT.Appearance = Appearance.Button;
			ItemOverviewRBT.Location = new Point(0, 103);
			ItemOverviewRBT.Margin = new Padding(2);
			ItemOverviewRBT.Name = "ItemOverviewRBT";
			ItemOverviewRBT.Size = new Size(316, 47);
			ItemOverviewRBT.TabIndex = 0;
			ItemOverviewRBT.Text = "Items Overview";
			ItemOverviewRBT.UseVisualStyleBackColor = true;
			ItemOverviewRBT.CheckedChanged += ItemOverviewRBT_CheckedChanged;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Desktop;
			panel2.Controls.Add(label1);
			panel2.Location = new Point(-1, 1);
			panel2.Margin = new Padding(2);
			panel2.Name = "panel2";
			panel2.Size = new Size(317, 56);
			panel2.TabIndex = 1;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("MS Reference Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.GradientInactiveCaption;
			label1.Location = new Point(0, 0);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(317, 56);
			label1.TabIndex = 1;
			label1.Text = "Dashboard";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(WarehouseOverview);
			tabControl1.Controls.Add(ItemOverview);
			tabControl1.Controls.Add(CreateItems);
			tabControl1.Controls.Add(DeleteItems);
			tabControl1.Controls.Add(WarehouseEmployees);
			tabControl1.Location = new Point(319, 4);
			tabControl1.Margin = new Padding(2);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(817, 567);
			tabControl1.TabIndex = 2;
			// 
			// WarehouseOverview
			// 
			WarehouseOverview.Controls.Add(groupBox6);
			WarehouseOverview.Controls.Add(WarehouseItemRestocking);
			WarehouseOverview.Controls.Add(ShopRequests);
			WarehouseOverview.Controls.Add(RefreshDataBTN);
			WarehouseOverview.Controls.Add(groupBox2);
			WarehouseOverview.Controls.Add(Add);
			WarehouseOverview.Controls.Add(warehouseListbox);
			WarehouseOverview.Location = new Point(4, 24);
			WarehouseOverview.Margin = new Padding(2);
			WarehouseOverview.Name = "WarehouseOverview";
			WarehouseOverview.Size = new Size(809, 539);
			WarehouseOverview.TabIndex = 4;
			WarehouseOverview.Text = "WarehouseOverview";
			WarehouseOverview.UseVisualStyleBackColor = true;
			// 
			// WarehouseItemRestocking
			// 
			WarehouseItemRestocking.FormattingEnabled = true;
			WarehouseItemRestocking.ItemHeight = 15;
			WarehouseItemRestocking.Location = new Point(377, 360);
			WarehouseItemRestocking.Margin = new Padding(2);
			WarehouseItemRestocking.Name = "WarehouseItemRestocking";
			WarehouseItemRestocking.Size = new Size(429, 169);
			WarehouseItemRestocking.TabIndex = 11;
			// 
			// ShopRequests
			// 
			ShopRequests.FormattingEnabled = true;
			ShopRequests.ItemHeight = 15;
			ShopRequests.Location = new Point(377, 241);
			ShopRequests.Margin = new Padding(2);
			ShopRequests.Name = "ShopRequests";
			ShopRequests.Size = new Size(429, 109);
			ShopRequests.TabIndex = 10;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button2);
			groupBox2.Controls.Add(Restock);
			groupBox2.Location = new Point(3, 148);
			groupBox2.Margin = new Padding(2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(2);
			groupBox2.Size = new Size(295, 134);
			groupBox2.TabIndex = 9;
			groupBox2.TabStop = false;
			groupBox2.Text = "Manage and restock";
			// 
			// button2
			// 
			button2.Location = new Point(12, 20);
			button2.Margin = new Padding(2);
			button2.Name = "button2";
			button2.Size = new Size(161, 32);
			button2.TabIndex = 1;
			button2.Text = "Send requested items";
			button2.UseVisualStyleBackColor = true;
			// 
			// Restock
			// 
			Restock.Location = new Point(12, 56);
			Restock.Margin = new Padding(2);
			Restock.Name = "Restock";
			Restock.Size = new Size(88, 20);
			Restock.TabIndex = 0;
			Restock.Text = "Restock Item";
			Restock.UseVisualStyleBackColor = true;
			// 
			// ViewItemsBTN
			// 
			ViewItemsBTN.Location = new Point(6, 38);
			ViewItemsBTN.Margin = new Padding(2);
			ViewItemsBTN.Name = "ViewItemsBTN";
			ViewItemsBTN.Size = new Size(275, 26);
			ViewItemsBTN.TabIndex = 8;
			ViewItemsBTN.Text = "View Items";
			ViewItemsBTN.UseVisualStyleBackColor = true;
			ViewItemsBTN.Click += ViewDataBTN_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(27, 19);
			label11.Margin = new Padding(2, 0, 2, 0);
			label11.Name = "label11";
			label11.Size = new Size(235, 15);
			label11.TabIndex = 7;
			label11.Text = "Select a warehouse first then press a button";
			// 
			// RefreshDataBTN
			// 
			RefreshDataBTN.Location = new Point(377, 219);
			RefreshDataBTN.Margin = new Padding(2);
			RefreshDataBTN.Name = "RefreshDataBTN";
			RefreshDataBTN.Size = new Size(86, 20);
			RefreshDataBTN.TabIndex = 6;
			RefreshDataBTN.Text = "Refresh Data";
			RefreshDataBTN.UseVisualStyleBackColor = true;
			RefreshDataBTN.Click += RefreshDataBTN_Click;
			// 
			// Add
			// 
			Add.Location = new Point(783, 217);
			Add.Margin = new Padding(2);
			Add.Name = "Add";
			Add.Size = new Size(22, 20);
			Add.TabIndex = 3;
			Add.Text = "+";
			Add.UseVisualStyleBackColor = true;
			Add.Click += Add_Click;
			// 
			// warehouseListbox
			// 
			warehouseListbox.FormattingEnabled = true;
			warehouseListbox.ItemHeight = 15;
			warehouseListbox.Location = new Point(377, 1);
			warehouseListbox.Margin = new Padding(2);
			warehouseListbox.Name = "warehouseListbox";
			warehouseListbox.Size = new Size(429, 214);
			warehouseListbox.TabIndex = 2;
			warehouseListbox.SelectedIndexChanged += warehouseListbox_SelectedIndexChanged;
			// 
			// ItemOverview
			// 
			ItemOverview.Controls.Add(groupBox3);
			ItemOverview.Controls.Add(groupBox1);
			ItemOverview.Controls.Add(label7);
			ItemOverview.Controls.Add(SearchItembyName);
			ItemOverview.Controls.Add(textBox1);
			ItemOverview.Controls.Add(label2);
			ItemOverview.Controls.Add(ItemListBox);
			ItemOverview.Controls.Add(ShowAllItems);
			ItemOverview.Location = new Point(4, 24);
			ItemOverview.Margin = new Padding(2);
			ItemOverview.Name = "ItemOverview";
			ItemOverview.Padding = new Padding(2);
			ItemOverview.Size = new Size(809, 539);
			ItemOverview.TabIndex = 0;
			ItemOverview.Text = "ItemOverview";
			ItemOverview.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(warehouseComboBox);
			groupBox3.Controls.Add(AssignItemBTN);
			groupBox3.Controls.Add(label12);
			groupBox3.Location = new Point(5, 334);
			groupBox3.Margin = new Padding(2);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(2);
			groupBox3.Size = new Size(286, 117);
			groupBox3.TabIndex = 7;
			groupBox3.TabStop = false;
			groupBox3.Text = "Assign Item to warehouse";
			// 
			// warehouseComboBox
			// 
			warehouseComboBox.FormattingEnabled = true;
			warehouseComboBox.Location = new Point(10, 41);
			warehouseComboBox.Margin = new Padding(2);
			warehouseComboBox.Name = "warehouseComboBox";
			warehouseComboBox.Size = new Size(268, 23);
			warehouseComboBox.TabIndex = 16;
			// 
			// AssignItemBTN
			// 
			AssignItemBTN.Location = new Point(5, 73);
			AssignItemBTN.Margin = new Padding(2);
			AssignItemBTN.Name = "AssignItemBTN";
			AssignItemBTN.Size = new Size(275, 26);
			AssignItemBTN.TabIndex = 15;
			AssignItemBTN.Text = "Assign selected item to warehouse";
			AssignItemBTN.UseVisualStyleBackColor = true;
			AssignItemBTN.Click += AssignItemBTN_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(5, 22);
			label12.Margin = new Padding(2, 0, 2, 0);
			label12.Name = "label12";
			label12.Size = new Size(182, 15);
			label12.TabIndex = 14;
			label12.Text = "input the name of the warehouse";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBox10);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(textBox6);
			groupBox1.Controls.Add(textBox7);
			groupBox1.Controls.Add(textBox8);
			groupBox1.Location = new Point(5, 118);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(286, 211);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Update Items";
			// 
			// textBox10
			// 
			textBox10.Location = new Point(98, 141);
			textBox10.Margin = new Padding(2);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(180, 23);
			textBox10.TabIndex = 14;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(5, 145);
			label15.Margin = new Padding(2, 0, 2, 0);
			label15.Name = "label15";
			label15.Size = new Size(83, 15);
			label15.TabIndex = 13;
			label15.Text = "Shop Quantity";
			// 
			// button1
			// 
			button1.Location = new Point(98, 171);
			button1.Name = "button1";
			button1.Size = new Size(79, 25);
			button1.TabIndex = 12;
			button1.Text = "Update";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(5, 110);
			label8.Margin = new Padding(2, 0, 2, 0);
			label8.Name = "label8";
			label8.Size = new Size(115, 15);
			label8.TabIndex = 11;
			label8.Text = "Warehouse Quantity";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(5, 73);
			label9.Margin = new Padding(2, 0, 2, 0);
			label9.Name = "label9";
			label9.Size = new Size(67, 15);
			label9.TabIndex = 10;
			label9.Text = "Description";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(5, 41);
			label10.Margin = new Padding(2, 0, 2, 0);
			label10.Name = "label10";
			label10.Size = new Size(39, 15);
			label10.TabIndex = 9;
			label10.Text = "Name";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(127, 108);
			textBox6.Margin = new Padding(2);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(160, 23);
			textBox6.TabIndex = 8;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(82, 70);
			textBox7.Margin = new Padding(2);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(199, 23);
			textBox7.TabIndex = 7;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(82, 38);
			textBox8.Margin = new Padding(2);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(199, 23);
			textBox8.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(2, 47);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(103, 15);
			label7.TabIndex = 5;
			label7.Text = "Number of items: ";
			// 
			// SearchItembyName
			// 
			SearchItembyName.Location = new Point(206, 15);
			SearchItembyName.Margin = new Padding(2);
			SearchItembyName.Name = "SearchItembyName";
			SearchItembyName.Size = new Size(93, 28);
			SearchItembyName.TabIndex = 4;
			SearchItembyName.Text = "Search";
			SearchItembyName.UseVisualStyleBackColor = true;
			SearchItembyName.Click += SearchItembyName_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(2, 20);
			textBox1.Margin = new Padding(2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(200, 23);
			textBox1.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(41, 3);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(118, 15);
			label2.TabIndex = 2;
			label2.Text = "Search item by name";
			// 
			// ItemListBox
			// 
			ItemListBox.FormattingEnabled = true;
			ItemListBox.ItemHeight = 15;
			ItemListBox.Location = new Point(385, 2);
			ItemListBox.Margin = new Padding(2);
			ItemListBox.Name = "ItemListBox";
			ItemListBox.Size = new Size(420, 529);
			ItemListBox.TabIndex = 1;
			// 
			// ShowAllItems
			// 
			ShowAllItems.Location = new Point(2, 75);
			ShowAllItems.Margin = new Padding(2);
			ShowAllItems.Name = "ShowAllItems";
			ShowAllItems.Size = new Size(295, 29);
			ShowAllItems.TabIndex = 0;
			ShowAllItems.Text = "Show all items";
			ShowAllItems.UseVisualStyleBackColor = true;
			ShowAllItems.Click += ShowAllItems_Click;
			// 
			// CreateItems
			// 
			CreateItems.Controls.Add(textBox9);
			CreateItems.Controls.Add(label14);
			CreateItems.Controls.Add(quantityTB);
			CreateItems.Controls.Add(label13);
			CreateItems.Controls.Add(button3);
			CreateItems.Controls.Add(textBox4);
			CreateItems.Controls.Add(textBox3);
			CreateItems.Controls.Add(textBox2);
			CreateItems.Controls.Add(label5);
			CreateItems.Controls.Add(label4);
			CreateItems.Controls.Add(label3);
			CreateItems.Location = new Point(4, 24);
			CreateItems.Margin = new Padding(2);
			CreateItems.Name = "CreateItems";
			CreateItems.Padding = new Padding(2);
			CreateItems.Size = new Size(809, 539);
			CreateItems.TabIndex = 1;
			CreateItems.Text = "CreateItems";
			CreateItems.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			textBox9.Location = new Point(169, 140);
			textBox9.Margin = new Padding(2);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(199, 23);
			textBox9.TabIndex = 10;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(28, 143);
			label14.Margin = new Padding(2, 0, 2, 0);
			label14.Name = "label14";
			label14.Size = new Size(83, 15);
			label14.TabIndex = 9;
			label14.Text = "Shop Quantity";
			// 
			// quantityTB
			// 
			quantityTB.Location = new Point(169, 95);
			quantityTB.Margin = new Padding(2);
			quantityTB.Name = "quantityTB";
			quantityTB.Size = new Size(199, 23);
			quantityTB.TabIndex = 8;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(28, 99);
			label13.Margin = new Padding(2, 0, 2, 0);
			label13.Name = "label13";
			label13.Size = new Size(115, 15);
			label13.TabIndex = 7;
			label13.Text = "Warehouse Quantity";
			// 
			// button3
			// 
			button3.Location = new Point(28, 222);
			button3.Margin = new Padding(2);
			button3.Name = "button3";
			button3.Size = new Size(318, 25);
			button3.TabIndex = 6;
			button3.Text = "Create item";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(169, 175);
			textBox4.Margin = new Padding(2);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(199, 23);
			textBox4.TabIndex = 5;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(169, 62);
			textBox3.Margin = new Padding(2);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(199, 23);
			textBox3.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(169, 29);
			textBox2.Margin = new Padding(2);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(199, 23);
			textBox2.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 179);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 2;
			label5.Text = "Category";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(28, 65);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(67, 15);
			label4.TabIndex = 1;
			label4.Text = "Description";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(28, 33);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(100, 15);
			label3.TabIndex = 0;
			label3.Text = "Name of the item";
			// 
			// DeleteItems
			// 
			DeleteItems.Controls.Add(button5);
			DeleteItems.Controls.Add(button4);
			DeleteItems.Controls.Add(textBox5);
			DeleteItems.Controls.Add(label6);
			DeleteItems.Controls.Add(listBox1);
			DeleteItems.Location = new Point(4, 24);
			DeleteItems.Margin = new Padding(2);
			DeleteItems.Name = "DeleteItems";
			DeleteItems.Padding = new Padding(2);
			DeleteItems.Size = new Size(809, 539);
			DeleteItems.TabIndex = 2;
			DeleteItems.Text = "DeleteItems";
			DeleteItems.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(4, 71);
			button5.Margin = new Padding(2);
			button5.Name = "button5";
			button5.Size = new Size(374, 37);
			button5.TabIndex = 6;
			button5.Text = "Delete selected item";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button4
			// 
			button4.Location = new Point(261, 26);
			button4.Margin = new Padding(2);
			button4.Name = "button4";
			button4.Size = new Size(93, 25);
			button4.TabIndex = 5;
			button4.Text = "Search";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(43, 30);
			textBox5.Margin = new Padding(2);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(200, 23);
			textBox5.TabIndex = 4;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(111, 10);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(69, 15);
			label6.TabIndex = 3;
			label6.Text = "Search item";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(382, 2);
			listBox1.Margin = new Padding(2);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(426, 544);
			listBox1.TabIndex = 2;
			// 
			// WarehouseEmployees
			// 
			WarehouseEmployees.Controls.Add(groupBox5);
			WarehouseEmployees.Controls.Add(groupBox4);
			WarehouseEmployees.Controls.Add(employeeList);
			WarehouseEmployees.Location = new Point(4, 24);
			WarehouseEmployees.Margin = new Padding(2);
			WarehouseEmployees.Name = "WarehouseEmployees";
			WarehouseEmployees.Padding = new Padding(2);
			WarehouseEmployees.Size = new Size(809, 539);
			WarehouseEmployees.TabIndex = 5;
			WarehouseEmployees.Text = "WarehouseEmployees";
			WarehouseEmployees.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(SearchForEmployeesBTN);
			groupBox5.Controls.Add(label17);
			groupBox5.Controls.Add(textBox11);
			groupBox5.Location = new Point(5, 5);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(388, 117);
			groupBox5.TabIndex = 11;
			groupBox5.TabStop = false;
			groupBox5.Text = "Search for employees";
			// 
			// SearchForEmployeesBTN
			// 
			SearchForEmployeesBTN.Location = new Point(319, 20);
			SearchForEmployeesBTN.Name = "SearchForEmployeesBTN";
			SearchForEmployeesBTN.Size = new Size(66, 23);
			SearchForEmployeesBTN.TabIndex = 2;
			SearchForEmployeesBTN.Text = "Search";
			SearchForEmployeesBTN.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(6, 24);
			label17.Name = "label17";
			label17.Size = new Size(91, 15);
			label17.TabIndex = 1;
			label17.Text = "Search by name";
			// 
			// textBox11
			// 
			textBox11.Location = new Point(103, 21);
			textBox11.Name = "textBox11";
			textBox11.Size = new Size(208, 23);
			textBox11.TabIndex = 0;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(warehouseComboBox2);
			groupBox4.Controls.Add(AssignEmployeeToWarehouseBTN);
			groupBox4.Controls.Add(label16);
			groupBox4.Location = new Point(6, 132);
			groupBox4.Margin = new Padding(2);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(2);
			groupBox4.Size = new Size(387, 117);
			groupBox4.TabIndex = 8;
			groupBox4.TabStop = false;
			groupBox4.Text = "Assign employee to warehouse";
			// 
			// warehouseComboBox2
			// 
			warehouseComboBox2.FormattingEnabled = true;
			warehouseComboBox2.Location = new Point(5, 41);
			warehouseComboBox2.Margin = new Padding(2);
			warehouseComboBox2.Name = "warehouseComboBox2";
			warehouseComboBox2.Size = new Size(275, 23);
			warehouseComboBox2.TabIndex = 16;
			// 
			// AssignEmployeeToWarehouseBTN
			// 
			AssignEmployeeToWarehouseBTN.Location = new Point(5, 73);
			AssignEmployeeToWarehouseBTN.Margin = new Padding(2);
			AssignEmployeeToWarehouseBTN.Name = "AssignEmployeeToWarehouseBTN";
			AssignEmployeeToWarehouseBTN.Size = new Size(275, 26);
			AssignEmployeeToWarehouseBTN.TabIndex = 15;
			AssignEmployeeToWarehouseBTN.Text = "Assign selected employee to warehouse";
			AssignEmployeeToWarehouseBTN.UseVisualStyleBackColor = true;
			AssignEmployeeToWarehouseBTN.Click += AssignEmployeeToWarehouseBTN_Click;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(5, 18);
			label16.Margin = new Padding(2, 0, 2, 0);
			label16.Name = "label16";
			label16.Size = new Size(106, 15);
			label16.TabIndex = 14;
			label16.Text = "select a warehouse";
			// 
			// employeeList
			// 
			employeeList.FormattingEnabled = true;
			employeeList.ItemHeight = 15;
			employeeList.Location = new Point(395, 3);
			employeeList.Margin = new Padding(2);
			employeeList.Name = "employeeList";
			employeeList.Size = new Size(410, 244);
			employeeList.TabIndex = 5;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(ShowWarehouseEmployeesBTN);
			groupBox6.Controls.Add(label11);
			groupBox6.Controls.Add(ViewItemsBTN);
			groupBox6.Location = new Point(3, 3);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(295, 140);
			groupBox6.TabIndex = 19;
			groupBox6.TabStop = false;
			groupBox6.Text = "Show the items and employees of a warehouse";
			// 
			// ShowWarehouseEmployeesBTN
			// 
			ShowWarehouseEmployeesBTN.Location = new Point(6, 72);
			ShowWarehouseEmployeesBTN.Name = "ShowWarehouseEmployeesBTN";
			ShowWarehouseEmployeesBTN.Size = new Size(275, 29);
			ShowWarehouseEmployeesBTN.TabIndex = 10;
			ShowWarehouseEmployeesBTN.Text = "Show Warehouse Employees";
			ShowWarehouseEmployeesBTN.UseVisualStyleBackColor = true;
			ShowWarehouseEmployeesBTN.Click += ShowWarehouseEmployeesBTN_Click;
			// 
			// WarehouseManager
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1135, 571);
			Controls.Add(tabControl1);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(2);
			Name = "WarehouseManager";
			Text = "ItemManager";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			WarehouseOverview.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ItemOverview.ResumeLayout(false);
			ItemOverview.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			CreateItems.ResumeLayout(false);
			CreateItems.PerformLayout();
			DeleteItems.ResumeLayout(false);
			DeleteItems.PerformLayout();
			WarehouseEmployees.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private RadioButton ItemOverviewRBT;
		private Panel panel2;
		private Label label1;
		private RadioButton DeleteItemsRBT;
		private RadioButton CreateItemsRBT;
		private TabControl tabControl1;
		private TabPage ItemOverview;
		private TabPage CreateItems;
		private TabPage DeleteItems;
		private Button SearchItembyName;
		private TextBox textBox1;
		private Label label2;
		private ListBox ItemListBox;
		private Button ShowAllItems;
		private Label label7;
		private Button button3;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button button5;
		private Button button4;
		private TextBox textBox5;
		private Label label6;
		private ListBox listBox1;
		private RadioButton radioButton1;
		private TabPage WarehouseOverview;
		private ListBox warehouseListbox;
		private GroupBox groupBox1;
		private Button button1;
		private Label label8;
		private Label label9;
		private Label label10;
		private TextBox textBox6;
		private TextBox textBox7;
		private TextBox textBox8;
		private RadioButton WarehouseEmployeeRBT;
		private TabPage WarehouseEmployees;
		private ListBox employeeList;
		private Button Add;
		private ListBox ShopRequests;
		private GroupBox groupBox2;
		private Button button2;
		private Button Restock;
		private Button ViewItemsBTN;
		private Label label11;
		private Button RefreshDataBTN;
		private GroupBox groupBox3;
		private Button AssignItemBTN;
		private Label label12;
		private TextBox quantityTB;
		private Label label13;
		private TextBox textBox9;
		private Label label14;
		private ComboBox warehouseComboBox;
		private TextBox textBox10;
		private Label label15;
		private RadioButton radioButton2;
		private ListBox WarehouseItemRestocking;
		private GroupBox groupBox5;
		private Button SearchForEmployeesBTN;
		private Label label17;
		private TextBox textBox11;
		private GroupBox groupBox4;
		private ComboBox warehouseComboBox2;
		private Button AssignEmployeeToWarehouseBTN;
		private Label label16;
		private GroupBox groupBox6;
		private Button ShowWarehouseEmployeesBTN;
	}
}