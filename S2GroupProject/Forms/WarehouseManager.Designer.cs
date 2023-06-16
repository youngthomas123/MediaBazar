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
			label18 = new Label();
			groupBox6 = new GroupBox();
			ShowWarehouseEmployeesBTN = new Button();
			label11 = new Label();
			ViewItemsBTN = new Button();
			WarehouseItemRestocking = new ListBox();
			ShopRequests = new ListBox();
			RefreshDataBTN = new Button();
			groupBox2 = new GroupBox();
			button2 = new Button();
			Restock = new Button();
			Add = new Button();
			warehouseListbox = new ListBox();
			ItemOverview = new TabPage();
			groupBox7 = new GroupBox();
			label2 = new Label();
			SortByName = new Button();
			textBox1 = new TextBox();
			CategoriesBox = new ComboBox();
			label7 = new Label();
			SearchItembyName = new Button();
			groupBox3 = new GroupBox();
			warehouseComboBox = new ComboBox();
			AssignItemBTN = new Button();
			label12 = new Label();
			groupBox1 = new GroupBox();
			button1 = new Button();
			label9 = new Label();
			label10 = new Label();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			ItemListBox = new ListBox();
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
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tabControl1.SuspendLayout();
			WarehouseOverview.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox2.SuspendLayout();
			ItemOverview.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox1.SuspendLayout();
			CreateItems.SuspendLayout();
			DeleteItems.SuspendLayout();
			WarehouseEmployees.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightBlue;
			panel1.Controls.Add(radioButton2);
			panel1.Controls.Add(WarehouseEmployeeRBT);
			panel1.Controls.Add(radioButton1);
			panel1.Controls.Add(DeleteItemsRBT);
			panel1.Controls.Add(CreateItemsRBT);
			panel1.Controls.Add(ItemOverviewRBT);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(451, 952);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// radioButton2
			// 
			radioButton2.Appearance = Appearance.Button;
			radioButton2.Location = new Point(3, 870);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(449, 78);
			radioButton2.TabIndex = 6;
			radioButton2.Text = "Log out";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// WarehouseEmployeeRBT
			// 
			WarehouseEmployeeRBT.Appearance = Appearance.Button;
			WarehouseEmployeeRBT.Location = new Point(-1, 393);
			WarehouseEmployeeRBT.Name = "WarehouseEmployeeRBT";
			WarehouseEmployeeRBT.Size = new Size(451, 78);
			WarehouseEmployeeRBT.TabIndex = 5;
			WarehouseEmployeeRBT.Text = "Warehouse Employees";
			WarehouseEmployeeRBT.UseVisualStyleBackColor = true;
			WarehouseEmployeeRBT.CheckedChanged += WarehouseEmployeeRBT_CheckedChanged;
			// 
			// radioButton1
			// 
			radioButton1.Appearance = Appearance.Button;
			radioButton1.Location = new Point(-1, 98);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(451, 78);
			radioButton1.TabIndex = 4;
			radioButton1.Text = "Warehouse Overview";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// DeleteItemsRBT
			// 
			DeleteItemsRBT.Appearance = Appearance.Button;
			DeleteItemsRBT.Location = new Point(-1, 243);
			DeleteItemsRBT.Name = "DeleteItemsRBT";
			DeleteItemsRBT.Size = new Size(451, 78);
			DeleteItemsRBT.TabIndex = 2;
			DeleteItemsRBT.Text = "Delete Items";
			DeleteItemsRBT.UseVisualStyleBackColor = true;
			DeleteItemsRBT.CheckedChanged += DeleteItemsRBT_CheckedChanged;
			// 
			// CreateItemsRBT
			// 
			CreateItemsRBT.Appearance = Appearance.Button;
			CreateItemsRBT.Location = new Point(0, 318);
			CreateItemsRBT.Name = "CreateItemsRBT";
			CreateItemsRBT.Size = new Size(451, 78);
			CreateItemsRBT.TabIndex = 1;
			CreateItemsRBT.Text = "Create Items";
			CreateItemsRBT.UseVisualStyleBackColor = true;
			CreateItemsRBT.CheckedChanged += CreateItemsRBT_CheckedChanged;
			// 
			// ItemOverviewRBT
			// 
			ItemOverviewRBT.Appearance = Appearance.Button;
			ItemOverviewRBT.Location = new Point(0, 172);
			ItemOverviewRBT.Name = "ItemOverviewRBT";
			ItemOverviewRBT.Size = new Size(451, 78);
			ItemOverviewRBT.TabIndex = 0;
			ItemOverviewRBT.Text = "Items Overview";
			ItemOverviewRBT.UseVisualStyleBackColor = true;
			ItemOverviewRBT.CheckedChanged += ItemOverviewRBT_CheckedChanged;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Desktop;
			panel2.Controls.Add(label1);
			panel2.Location = new Point(-1, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(453, 93);
			panel2.TabIndex = 1;
			// 
			// label1
			// 
			label1.BackColor = Color.LightBlue;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("MS Reference Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Desktop;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(453, 93);
			label1.TabIndex = 1;
			label1.Text = "Dashboard";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(WarehouseOverview);
			tabControl1.Controls.Add(ItemOverview);
			tabControl1.Controls.Add(CreateItems);
			tabControl1.Controls.Add(DeleteItems);
			tabControl1.Controls.Add(WarehouseEmployees);
			tabControl1.Location = new Point(456, 7);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1167, 945);
			tabControl1.TabIndex = 2;
			// 
			// WarehouseOverview
			// 
			WarehouseOverview.Controls.Add(label18);
			WarehouseOverview.Controls.Add(groupBox6);
			WarehouseOverview.Controls.Add(WarehouseItemRestocking);
			WarehouseOverview.Controls.Add(ShopRequests);
			WarehouseOverview.Controls.Add(RefreshDataBTN);
			WarehouseOverview.Controls.Add(groupBox2);
			WarehouseOverview.Controls.Add(Add);
			WarehouseOverview.Controls.Add(warehouseListbox);
			WarehouseOverview.Location = new Point(4, 34);
			WarehouseOverview.Name = "WarehouseOverview";
			WarehouseOverview.Size = new Size(1159, 907);
			WarehouseOverview.TabIndex = 4;
			WarehouseOverview.Text = "WarehouseOverview";
			WarehouseOverview.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(539, 592);
			label18.Margin = new Padding(4, 0, 4, 0);
			label18.Name = "label18";
			label18.Size = new Size(223, 25);
			label18.TabIndex = 20;
			label18.Text = "Items that need restocking";
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(ShowWarehouseEmployeesBTN);
			groupBox6.Controls.Add(label11);
			groupBox6.Controls.Add(ViewItemsBTN);
			groupBox6.Location = new Point(4, 5);
			groupBox6.Margin = new Padding(4, 5, 4, 5);
			groupBox6.Name = "groupBox6";
			groupBox6.Padding = new Padding(4, 5, 4, 5);
			groupBox6.Size = new Size(421, 233);
			groupBox6.TabIndex = 19;
			groupBox6.TabStop = false;
			groupBox6.Text = "Show the items and employees of a warehouse";
			// 
			// ShowWarehouseEmployeesBTN
			// 
			ShowWarehouseEmployeesBTN.Location = new Point(9, 120);
			ShowWarehouseEmployeesBTN.Margin = new Padding(4, 5, 4, 5);
			ShowWarehouseEmployeesBTN.Name = "ShowWarehouseEmployeesBTN";
			ShowWarehouseEmployeesBTN.Size = new Size(393, 48);
			ShowWarehouseEmployeesBTN.TabIndex = 10;
			ShowWarehouseEmployeesBTN.Text = "Show Warehouse Employees";
			ShowWarehouseEmployeesBTN.UseVisualStyleBackColor = true;
			ShowWarehouseEmployeesBTN.Click += ShowWarehouseEmployeesBTN_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(39, 32);
			label11.Name = "label11";
			label11.Size = new Size(357, 25);
			label11.TabIndex = 7;
			label11.Text = "Select a warehouse first then press a button";
			// 
			// ViewItemsBTN
			// 
			ViewItemsBTN.Location = new Point(9, 63);
			ViewItemsBTN.Name = "ViewItemsBTN";
			ViewItemsBTN.Size = new Size(393, 43);
			ViewItemsBTN.TabIndex = 8;
			ViewItemsBTN.Text = "View Items";
			ViewItemsBTN.UseVisualStyleBackColor = true;
			ViewItemsBTN.Click += ViewDataBTN_Click;
			// 
			// WarehouseItemRestocking
			// 
			WarehouseItemRestocking.FormattingEnabled = true;
			WarehouseItemRestocking.ItemHeight = 25;
			WarehouseItemRestocking.Location = new Point(537, 620);
			WarehouseItemRestocking.Name = "WarehouseItemRestocking";
			WarehouseItemRestocking.Size = new Size(611, 279);
			WarehouseItemRestocking.TabIndex = 11;
			// 
			// ShopRequests
			// 
			ShopRequests.FormattingEnabled = true;
			ShopRequests.ItemHeight = 25;
			ShopRequests.Location = new Point(537, 407);
			ShopRequests.Name = "ShopRequests";
			ShopRequests.Size = new Size(611, 179);
			ShopRequests.TabIndex = 10;
			// 
			// RefreshDataBTN
			// 
			RefreshDataBTN.Location = new Point(539, 365);
			RefreshDataBTN.Name = "RefreshDataBTN";
			RefreshDataBTN.Size = new Size(123, 33);
			RefreshDataBTN.TabIndex = 6;
			RefreshDataBTN.Text = "Refresh Data";
			RefreshDataBTN.UseVisualStyleBackColor = true;
			RefreshDataBTN.Click += RefreshDataBTN_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button2);
			groupBox2.Controls.Add(Restock);
			groupBox2.Location = new Point(4, 247);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(421, 223);
			groupBox2.TabIndex = 9;
			groupBox2.TabStop = false;
			groupBox2.Text = "Manage and restock";
			// 
			// button2
			// 
			button2.Location = new Point(17, 33);
			button2.Name = "button2";
			button2.Size = new Size(230, 53);
			button2.TabIndex = 1;
			button2.Text = "Send requested items";
			button2.UseVisualStyleBackColor = true;
			// 
			// Restock
			// 
			Restock.Location = new Point(17, 93);
			Restock.Name = "Restock";
			Restock.Size = new Size(126, 33);
			Restock.TabIndex = 0;
			Restock.Text = "Restock Item";
			Restock.UseVisualStyleBackColor = true;
			Restock.Click += Restock_Click;
			// 
			// Add
			// 
			Add.Location = new Point(1119, 362);
			Add.Name = "Add";
			Add.Size = new Size(31, 33);
			Add.TabIndex = 3;
			Add.Text = "+";
			Add.UseVisualStyleBackColor = true;
			Add.Click += Add_Click;
			// 
			// warehouseListbox
			// 
			warehouseListbox.FormattingEnabled = true;
			warehouseListbox.ItemHeight = 25;
			warehouseListbox.Location = new Point(539, 2);
			warehouseListbox.Name = "warehouseListbox";
			warehouseListbox.Size = new Size(611, 354);
			warehouseListbox.TabIndex = 2;
			warehouseListbox.SelectedIndexChanged += warehouseListbox_SelectedIndexChanged;
			// 
			// ItemOverview
			// 
			ItemOverview.Controls.Add(groupBox7);
			ItemOverview.Controls.Add(groupBox3);
			ItemOverview.Controls.Add(groupBox1);
			ItemOverview.Controls.Add(ItemListBox);
			ItemOverview.Location = new Point(4, 34);
			ItemOverview.Name = "ItemOverview";
			ItemOverview.Padding = new Padding(3);
			ItemOverview.Size = new Size(1159, 907);
			ItemOverview.TabIndex = 0;
			ItemOverview.Text = "ItemOverview";
			ItemOverview.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(label2);
			groupBox7.Controls.Add(SortByName);
			groupBox7.Controls.Add(textBox1);
			groupBox7.Controls.Add(CategoriesBox);
			groupBox7.Controls.Add(label7);
			groupBox7.Controls.Add(SearchItembyName);
			groupBox7.Location = new Point(8, 6);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(419, 237);
			groupBox7.TabIndex = 11;
			groupBox7.TabStop = false;
			groupBox7.Text = "Search and filter";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(7, 40);
			label2.Name = "label2";
			label2.Size = new Size(162, 25);
			label2.TabIndex = 2;
			label2.Text = "Search by keyword";
			// 
			// SortByName
			// 
			SortByName.Location = new Point(268, 140);
			SortByName.Name = "SortByName";
			SortByName.Size = new Size(145, 34);
			SortByName.TabIndex = 10;
			SortByName.Text = "Sort by Name";
			SortByName.UseVisualStyleBackColor = true;
			SortByName.Click += SortByName_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(0, 68);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(284, 31);
			textBox1.TabIndex = 3;
			// 
			// CategoriesBox
			// 
			CategoriesBox.FormattingEnabled = true;
			CategoriesBox.Location = new Point(6, 142);
			CategoriesBox.Name = "CategoriesBox";
			CategoriesBox.Size = new Size(196, 33);
			CategoriesBox.TabIndex = 8;
			CategoriesBox.SelectedIndexChanged += CategoriesBox_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 114);
			label7.Name = "label7";
			label7.Size = new Size(149, 25);
			label7.TabIndex = 9;
			label7.Text = "Filter by category";
			// 
			// SearchItembyName
			// 
			SearchItembyName.Location = new Point(286, 68);
			SearchItembyName.Name = "SearchItembyName";
			SearchItembyName.Size = new Size(133, 31);
			SearchItembyName.TabIndex = 4;
			SearchItembyName.Text = "Search";
			SearchItembyName.UseVisualStyleBackColor = true;
			SearchItembyName.Click += SearchItembyName_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(warehouseComboBox);
			groupBox3.Controls.Add(AssignItemBTN);
			groupBox3.Controls.Add(label12);
			groupBox3.Location = new Point(15, 687);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(409, 195);
			groupBox3.TabIndex = 7;
			groupBox3.TabStop = false;
			groupBox3.Text = "Assign Item to warehouse";
			// 
			// warehouseComboBox
			// 
			warehouseComboBox.FormattingEnabled = true;
			warehouseComboBox.Location = new Point(14, 68);
			warehouseComboBox.Name = "warehouseComboBox";
			warehouseComboBox.Size = new Size(381, 33);
			warehouseComboBox.TabIndex = 16;
			// 
			// AssignItemBTN
			// 
			AssignItemBTN.Location = new Point(7, 122);
			AssignItemBTN.Name = "AssignItemBTN";
			AssignItemBTN.Size = new Size(393, 43);
			AssignItemBTN.TabIndex = 15;
			AssignItemBTN.Text = "Assign selected item to warehouse";
			AssignItemBTN.UseVisualStyleBackColor = true;
			AssignItemBTN.Click += AssignItemBTN_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(7, 37);
			label12.Name = "label12";
			label12.Size = new Size(274, 25);
			label12.TabIndex = 14;
			label12.Text = "input the name of the warehouse";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(textBox7);
			groupBox1.Controls.Add(textBox8);
			groupBox1.Location = new Point(8, 460);
			groupBox1.Margin = new Padding(4, 5, 4, 5);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 5, 4, 5);
			groupBox1.Size = new Size(416, 228);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Update Items";
			// 
			// button1
			// 
			button1.Location = new Point(117, 168);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(280, 42);
			button1.TabIndex = 12;
			button1.Text = "Update";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(7, 122);
			label9.Name = "label9";
			label9.Size = new Size(102, 25);
			label9.TabIndex = 10;
			label9.Text = "Description";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(7, 68);
			label10.Name = "label10";
			label10.Size = new Size(59, 25);
			label10.TabIndex = 9;
			label10.Text = "Name";
			// 
			// textBox7
			// 
			textBox7.Location = new Point(117, 117);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(283, 31);
			textBox7.TabIndex = 7;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(117, 63);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(283, 31);
			textBox8.TabIndex = 6;
			// 
			// ItemListBox
			// 
			ItemListBox.FormattingEnabled = true;
			ItemListBox.ItemHeight = 25;
			ItemListBox.Location = new Point(433, 3);
			ItemListBox.Name = "ItemListBox";
			ItemListBox.Size = new Size(715, 879);
			ItemListBox.TabIndex = 1;
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
			CreateItems.Location = new Point(4, 34);
			CreateItems.Name = "CreateItems";
			CreateItems.Padding = new Padding(3);
			CreateItems.Size = new Size(1159, 907);
			CreateItems.TabIndex = 1;
			CreateItems.Text = "CreateItems";
			CreateItems.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			textBox9.Location = new Point(241, 233);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(283, 31);
			textBox9.TabIndex = 10;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(40, 238);
			label14.Name = "label14";
			label14.Size = new Size(127, 25);
			label14.TabIndex = 9;
			label14.Text = "Shop Quantity";
			// 
			// quantityTB
			// 
			quantityTB.Location = new Point(241, 158);
			quantityTB.Name = "quantityTB";
			quantityTB.Size = new Size(283, 31);
			quantityTB.TabIndex = 8;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(40, 165);
			label13.Name = "label13";
			label13.Size = new Size(173, 25);
			label13.TabIndex = 7;
			label13.Text = "Warehouse Quantity";
			// 
			// button3
			// 
			button3.Location = new Point(40, 370);
			button3.Name = "button3";
			button3.Size = new Size(454, 42);
			button3.TabIndex = 6;
			button3.Text = "Create item";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(241, 292);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(283, 31);
			textBox4.TabIndex = 5;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(241, 103);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(283, 31);
			textBox3.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(241, 48);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(283, 31);
			textBox2.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(40, 298);
			label5.Name = "label5";
			label5.Size = new Size(84, 25);
			label5.TabIndex = 2;
			label5.Text = "Category";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(40, 108);
			label4.Name = "label4";
			label4.Size = new Size(102, 25);
			label4.TabIndex = 1;
			label4.Text = "Description";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(40, 55);
			label3.Name = "label3";
			label3.Size = new Size(151, 25);
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
			DeleteItems.Location = new Point(4, 34);
			DeleteItems.Name = "DeleteItems";
			DeleteItems.Padding = new Padding(3);
			DeleteItems.Size = new Size(1159, 907);
			DeleteItems.TabIndex = 2;
			DeleteItems.Text = "DeleteItems";
			DeleteItems.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(6, 118);
			button5.Name = "button5";
			button5.Size = new Size(534, 62);
			button5.TabIndex = 6;
			button5.Text = "Delete selected item";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button4
			// 
			button4.Location = new Point(373, 43);
			button4.Name = "button4";
			button4.Size = new Size(133, 42);
			button4.TabIndex = 5;
			button4.Text = "Search";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(61, 50);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(284, 31);
			textBox5.TabIndex = 4;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(159, 17);
			label6.Name = "label6";
			label6.Size = new Size(104, 25);
			label6.TabIndex = 3;
			label6.Text = "Search item";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 25;
			listBox1.Location = new Point(546, 3);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(607, 904);
			listBox1.TabIndex = 2;
			// 
			// WarehouseEmployees
			// 
			WarehouseEmployees.Controls.Add(groupBox5);
			WarehouseEmployees.Controls.Add(groupBox4);
			WarehouseEmployees.Controls.Add(employeeList);
			WarehouseEmployees.Location = new Point(4, 34);
			WarehouseEmployees.Name = "WarehouseEmployees";
			WarehouseEmployees.Padding = new Padding(3);
			WarehouseEmployees.Size = new Size(1159, 907);
			WarehouseEmployees.TabIndex = 5;
			WarehouseEmployees.Text = "WarehouseEmployees";
			WarehouseEmployees.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(SearchForEmployeesBTN);
			groupBox5.Controls.Add(label17);
			groupBox5.Controls.Add(textBox11);
			groupBox5.Location = new Point(7, 8);
			groupBox5.Margin = new Padding(4, 5, 4, 5);
			groupBox5.Name = "groupBox5";
			groupBox5.Padding = new Padding(4, 5, 4, 5);
			groupBox5.Size = new Size(554, 195);
			groupBox5.TabIndex = 11;
			groupBox5.TabStop = false;
			groupBox5.Text = "Search for employees";
			// 
			// SearchForEmployeesBTN
			// 
			SearchForEmployeesBTN.Location = new Point(456, 33);
			SearchForEmployeesBTN.Margin = new Padding(4, 5, 4, 5);
			SearchForEmployeesBTN.Name = "SearchForEmployeesBTN";
			SearchForEmployeesBTN.Size = new Size(94, 38);
			SearchForEmployeesBTN.TabIndex = 2;
			SearchForEmployeesBTN.Text = "Search";
			SearchForEmployeesBTN.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(9, 40);
			label17.Margin = new Padding(4, 0, 4, 0);
			label17.Name = "label17";
			label17.Size = new Size(138, 25);
			label17.TabIndex = 1;
			label17.Text = "Search by name";
			// 
			// textBox11
			// 
			textBox11.Location = new Point(147, 35);
			textBox11.Margin = new Padding(4, 5, 4, 5);
			textBox11.Name = "textBox11";
			textBox11.Size = new Size(295, 31);
			textBox11.TabIndex = 0;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(warehouseComboBox2);
			groupBox4.Controls.Add(AssignEmployeeToWarehouseBTN);
			groupBox4.Controls.Add(label16);
			groupBox4.Location = new Point(9, 220);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(553, 195);
			groupBox4.TabIndex = 8;
			groupBox4.TabStop = false;
			groupBox4.Text = "Assign employee to warehouse";
			// 
			// warehouseComboBox2
			// 
			warehouseComboBox2.FormattingEnabled = true;
			warehouseComboBox2.Location = new Point(7, 68);
			warehouseComboBox2.Name = "warehouseComboBox2";
			warehouseComboBox2.Size = new Size(391, 33);
			warehouseComboBox2.TabIndex = 16;
			// 
			// AssignEmployeeToWarehouseBTN
			// 
			AssignEmployeeToWarehouseBTN.Location = new Point(7, 122);
			AssignEmployeeToWarehouseBTN.Name = "AssignEmployeeToWarehouseBTN";
			AssignEmployeeToWarehouseBTN.Size = new Size(393, 43);
			AssignEmployeeToWarehouseBTN.TabIndex = 15;
			AssignEmployeeToWarehouseBTN.Text = "Assign selected employee to warehouse";
			AssignEmployeeToWarehouseBTN.UseVisualStyleBackColor = true;
			AssignEmployeeToWarehouseBTN.Click += AssignEmployeeToWarehouseBTN_Click;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(7, 30);
			label16.Name = "label16";
			label16.Size = new Size(160, 25);
			label16.TabIndex = 14;
			label16.Text = "select a warehouse";
			// 
			// employeeList
			// 
			employeeList.FormattingEnabled = true;
			employeeList.ItemHeight = 25;
			employeeList.Location = new Point(564, 5);
			employeeList.Name = "employeeList";
			employeeList.Size = new Size(584, 404);
			employeeList.TabIndex = 5;
			// 
			// WarehouseManager
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1621, 952);
			Controls.Add(tabControl1);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "WarehouseManager";
			Text = "ItemManager";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			WarehouseOverview.ResumeLayout(false);
			WarehouseOverview.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox2.ResumeLayout(false);
			ItemOverview.ResumeLayout(false);
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
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
		private Label label9;
		private Label label10;
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
		private Label label18;
		private Label label7;
		private ComboBox CategoriesBox;
		private Button SortByName;
		private GroupBox groupBox7;
	}
}