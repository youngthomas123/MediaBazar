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
			ViewDataBTN = new Button();
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
			employeeList = new ListBox();
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
			radioButton2.Size = new Size(451, 78);
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
			ItemOverviewRBT.Checked = true;
			ItemOverviewRBT.Location = new Point(0, 172);
			ItemOverviewRBT.Name = "ItemOverviewRBT";
			ItemOverviewRBT.Size = new Size(451, 78);
			ItemOverviewRBT.TabIndex = 0;
			ItemOverviewRBT.TabStop = true;
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
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("MS Reference Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.GradientInactiveCaption;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(453, 93);
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
			tabControl1.Location = new Point(456, 7);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1167, 945);
			tabControl1.TabIndex = 2;
			// 
			// WarehouseOverview
			// 
			WarehouseOverview.Controls.Add(WarehouseItemRestocking);
			WarehouseOverview.Controls.Add(ShopRequests);
			WarehouseOverview.Controls.Add(groupBox2);
			WarehouseOverview.Controls.Add(ViewDataBTN);
			WarehouseOverview.Controls.Add(label11);
			WarehouseOverview.Controls.Add(RefreshDataBTN);
			WarehouseOverview.Controls.Add(Add);
			WarehouseOverview.Controls.Add(warehouseListbox);
			WarehouseOverview.Location = new Point(4, 34);
			WarehouseOverview.Name = "WarehouseOverview";
			WarehouseOverview.Size = new Size(1159, 907);
			WarehouseOverview.TabIndex = 4;
			WarehouseOverview.Text = "WarehouseOverview";
			WarehouseOverview.UseVisualStyleBackColor = true;
			// 
			// WarehouseItemRestocking
			// 
			WarehouseItemRestocking.FormattingEnabled = true;
			WarehouseItemRestocking.ItemHeight = 25;
			WarehouseItemRestocking.Location = new Point(538, 600);
			WarehouseItemRestocking.Name = "WarehouseItemRestocking";
			WarehouseItemRestocking.Size = new Size(611, 304);
			WarehouseItemRestocking.TabIndex = 11;
			// 
			// ShopRequests
			// 
			ShopRequests.FormattingEnabled = true;
			ShopRequests.ItemHeight = 25;
			ShopRequests.Location = new Point(538, 401);
			ShopRequests.Name = "ShopRequests";
			ShopRequests.Size = new Size(611, 179);
			ShopRequests.TabIndex = 10;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button2);
			groupBox2.Controls.Add(Restock);
			groupBox2.Location = new Point(3, 676);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(414, 223);
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
			// 
			// ViewDataBTN
			// 
			ViewDataBTN.Location = new Point(103, 62);
			ViewDataBTN.Name = "ViewDataBTN";
			ViewDataBTN.Size = new Size(191, 33);
			ViewDataBTN.TabIndex = 8;
			ViewDataBTN.Text = "View Data";
			ViewDataBTN.UseVisualStyleBackColor = true;
			ViewDataBTN.Click += ViewDataBTN_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(46, 33);
			label11.Name = "label11";
			label11.Size = new Size(336, 25);
			label11.TabIndex = 7;
			label11.Text = "Select a warehouse and press 'View Data'";
			// 
			// RefreshDataBTN
			// 
			RefreshDataBTN.Location = new Point(538, 362);
			RefreshDataBTN.Name = "RefreshDataBTN";
			RefreshDataBTN.Size = new Size(191, 33);
			RefreshDataBTN.TabIndex = 6;
			RefreshDataBTN.Text = "Refresh Data";
			RefreshDataBTN.UseVisualStyleBackColor = true;
			RefreshDataBTN.Click += RefreshDataBTN_Click;
			// 
			// Add
			// 
			Add.Location = new Point(1118, 362);
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
			warehouseListbox.Location = new Point(538, 2);
			warehouseListbox.Name = "warehouseListbox";
			warehouseListbox.Size = new Size(611, 354);
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
			ItemOverview.Location = new Point(4, 34);
			ItemOverview.Name = "ItemOverview";
			ItemOverview.Padding = new Padding(3);
			ItemOverview.Size = new Size(1159, 907);
			ItemOverview.TabIndex = 0;
			ItemOverview.Text = "ItemOverview";
			ItemOverview.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(warehouseComboBox);
			groupBox3.Controls.Add(AssignItemBTN);
			groupBox3.Controls.Add(label12);
			groupBox3.Location = new Point(10, 706);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(409, 195);
			groupBox3.TabIndex = 7;
			groupBox3.TabStop = false;
			groupBox3.Text = "Assign Item to warehouse";
			// 
			// warehouseComboBox
			// 
			warehouseComboBox.FormattingEnabled = true;
			warehouseComboBox.Location = new Point(15, 69);
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
			groupBox1.Controls.Add(textBox10);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(textBox6);
			groupBox1.Controls.Add(textBox7);
			groupBox1.Controls.Add(textBox8);
			groupBox1.Location = new Point(10, 347);
			groupBox1.Margin = new Padding(4, 5, 4, 5);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 5, 4, 5);
			groupBox1.Size = new Size(409, 351);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Update Items";
			// 
			// textBox10
			// 
			textBox10.Location = new Point(140, 235);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(256, 31);
			textBox10.TabIndex = 14;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(7, 241);
			label15.Name = "label15";
			label15.Size = new Size(127, 25);
			label15.TabIndex = 13;
			label15.Text = "Shop Quantity";
			// 
			// button1
			// 
			button1.Location = new Point(140, 285);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(113, 42);
			button1.TabIndex = 12;
			button1.Text = "Update";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(7, 183);
			label8.Name = "label8";
			label8.Size = new Size(173, 25);
			label8.TabIndex = 11;
			label8.Text = "Warehouse Quantity";
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
			// textBox6
			// 
			textBox6.Location = new Point(182, 180);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(227, 31);
			textBox6.TabIndex = 8;
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
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(3, 67);
			label7.Name = "label7";
			label7.Size = new Size(156, 25);
			label7.TabIndex = 5;
			label7.Text = "Number of items: ";
			// 
			// SearchItembyName
			// 
			SearchItembyName.Location = new Point(294, 25);
			SearchItembyName.Name = "SearchItembyName";
			SearchItembyName.Size = new Size(133, 47);
			SearchItembyName.TabIndex = 4;
			SearchItembyName.Text = "Search";
			SearchItembyName.UseVisualStyleBackColor = true;
			SearchItembyName.Click += SearchItembyName_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(3, 33);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(284, 31);
			textBox1.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(59, 5);
			label2.Name = "label2";
			label2.Size = new Size(178, 25);
			label2.TabIndex = 2;
			label2.Text = "Search item by name";
			// 
			// ItemListBox
			// 
			ItemListBox.FormattingEnabled = true;
			ItemListBox.ItemHeight = 25;
			ItemListBox.Location = new Point(550, 3);
			ItemListBox.Name = "ItemListBox";
			ItemListBox.Size = new Size(599, 879);
			ItemListBox.TabIndex = 1;
			// 
			// ShowAllItems
			// 
			ShowAllItems.Location = new Point(3, 95);
			ShowAllItems.Name = "ShowAllItems";
			ShowAllItems.Size = new Size(421, 48);
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
			label14.Location = new Point(40, 239);
			label14.Name = "label14";
			label14.Size = new Size(127, 25);
			label14.TabIndex = 9;
			label14.Text = "Shop Quantity";
			// 
			// quantityTB
			// 
			quantityTB.Location = new Point(241, 159);
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
			textBox3.Location = new Point(241, 104);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(283, 31);
			textBox3.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(241, 49);
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
			button5.Location = new Point(6, 119);
			button5.Name = "button5";
			button5.Size = new Size(534, 62);
			button5.TabIndex = 6;
			button5.Text = "Delete selected item";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button4
			// 
			button4.Location = new Point(373, 44);
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
			WarehouseEmployees.Controls.Add(employeeList);
			WarehouseEmployees.Location = new Point(4, 34);
			WarehouseEmployees.Name = "WarehouseEmployees";
			WarehouseEmployees.Padding = new Padding(3);
			WarehouseEmployees.Size = new Size(1159, 907);
			WarehouseEmployees.TabIndex = 5;
			WarehouseEmployees.Text = "WarehouseEmployees";
			WarehouseEmployees.UseVisualStyleBackColor = true;
			// 
			// employeeList
			// 
			employeeList.FormattingEnabled = true;
			employeeList.ItemHeight = 25;
			employeeList.Location = new Point(563, 6);
			employeeList.Name = "employeeList";
			employeeList.Size = new Size(590, 404);
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
		private Button ViewDataBTN;
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
	}
}