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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.UpdateItemsRBT = new System.Windows.Forms.RadioButton();
            this.DeleteItemsRBT = new System.Windows.Forms.RadioButton();
            this.CreateItemsRBT = new System.Windows.Forms.RadioButton();
            this.ItemOverviewRBT = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WarehouseOverview = new System.Windows.Forms.TabPage();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.warehouseListbox = new System.Windows.Forms.ListBox();
            this.ItemOverview = new System.Windows.Forms.TabPage();
            this.RefreshNumberOfItems = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchItembyName = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ShowAllItems = new System.Windows.Forms.Button();
            this.CreateItems = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteItems = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UpdateItems = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.WarehouseOverview.SuspendLayout();
            this.ItemOverview.SuspendLayout();
            this.CreateItems.SuspendLayout();
            this.DeleteItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.UpdateItemsRBT);
            this.panel1.Controls.Add(this.DeleteItemsRBT);
            this.panel1.Controls.Add(this.CreateItemsRBT);
            this.panel1.Controls.Add(this.ItemOverviewRBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 821);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.Location = new System.Drawing.Point(-1, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(453, 78);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Warehouse Overview";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // UpdateItemsRBT
            // 
            this.UpdateItemsRBT.Appearance = System.Windows.Forms.Appearance.Button;
            this.UpdateItemsRBT.Location = new System.Drawing.Point(-1, 319);
            this.UpdateItemsRBT.Name = "UpdateItemsRBT";
            this.UpdateItemsRBT.Size = new System.Drawing.Size(453, 78);
            this.UpdateItemsRBT.TabIndex = 3;
            this.UpdateItemsRBT.Text = "Update Items";
            this.UpdateItemsRBT.UseVisualStyleBackColor = true;
            this.UpdateItemsRBT.CheckedChanged += new System.EventHandler(this.UpdateItemsRBT_CheckedChanged);
            // 
            // DeleteItemsRBT
            // 
            this.DeleteItemsRBT.Appearance = System.Windows.Forms.Appearance.Button;
            this.DeleteItemsRBT.Location = new System.Drawing.Point(-1, 244);
            this.DeleteItemsRBT.Name = "DeleteItemsRBT";
            this.DeleteItemsRBT.Size = new System.Drawing.Size(453, 78);
            this.DeleteItemsRBT.TabIndex = 2;
            this.DeleteItemsRBT.Text = "Delete Items";
            this.DeleteItemsRBT.UseVisualStyleBackColor = true;
            this.DeleteItemsRBT.CheckedChanged += new System.EventHandler(this.DeleteItemsRBT_CheckedChanged);
            // 
            // CreateItemsRBT
            // 
            this.CreateItemsRBT.Appearance = System.Windows.Forms.Appearance.Button;
            this.CreateItemsRBT.Location = new System.Drawing.Point(-1, 169);
            this.CreateItemsRBT.Name = "CreateItemsRBT";
            this.CreateItemsRBT.Size = new System.Drawing.Size(453, 78);
            this.CreateItemsRBT.TabIndex = 1;
            this.CreateItemsRBT.Text = "Create Items";
            this.CreateItemsRBT.UseVisualStyleBackColor = true;
            this.CreateItemsRBT.CheckedChanged += new System.EventHandler(this.CreateItemsRBT_CheckedChanged);
            // 
            // ItemOverviewRBT
            // 
            this.ItemOverviewRBT.Appearance = System.Windows.Forms.Appearance.Button;
            this.ItemOverviewRBT.Checked = true;
            this.ItemOverviewRBT.Location = new System.Drawing.Point(-1, 394);
            this.ItemOverviewRBT.Name = "ItemOverviewRBT";
            this.ItemOverviewRBT.Size = new System.Drawing.Size(453, 78);
            this.ItemOverviewRBT.TabIndex = 0;
            this.ItemOverviewRBT.TabStop = true;
            this.ItemOverviewRBT.Text = "Items Overview";
            this.ItemOverviewRBT.UseVisualStyleBackColor = true;
            this.ItemOverviewRBT.CheckedChanged += new System.EventHandler(this.ItemOverviewRBT_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 94);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WarehouseOverview);
            this.tabControl1.Controls.Add(this.ItemOverview);
            this.tabControl1.Controls.Add(this.CreateItems);
            this.tabControl1.Controls.Add(this.DeleteItems);
            this.tabControl1.Controls.Add(this.UpdateItems);
            this.tabControl1.Location = new System.Drawing.Point(456, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 819);
            this.tabControl1.TabIndex = 2;
            // 
            // WarehouseOverview
            // 
            this.WarehouseOverview.Controls.Add(this.ItemList);
            this.WarehouseOverview.Controls.Add(this.warehouseListbox);
            this.WarehouseOverview.Location = new System.Drawing.Point(4, 34);
            this.WarehouseOverview.Name = "WarehouseOverview";
            this.WarehouseOverview.Size = new System.Drawing.Size(1035, 781);
            this.WarehouseOverview.TabIndex = 4;
            this.WarehouseOverview.Text = "WarehouseOverview";
            this.WarehouseOverview.UseVisualStyleBackColor = true;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 25;
            this.ItemList.Location = new System.Drawing.Point(357, 262);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(678, 229);
            this.ItemList.TabIndex = 3;
            // 
            // warehouseListbox
            // 
            this.warehouseListbox.FormattingEnabled = true;
            this.warehouseListbox.ItemHeight = 25;
            this.warehouseListbox.Location = new System.Drawing.Point(357, 1);
            this.warehouseListbox.Name = "warehouseListbox";
            this.warehouseListbox.Size = new System.Drawing.Size(678, 229);
            this.warehouseListbox.TabIndex = 2;
            // 
            // ItemOverview
            // 
            this.ItemOverview.Controls.Add(this.RefreshNumberOfItems);
            this.ItemOverview.Controls.Add(this.label7);
            this.ItemOverview.Controls.Add(this.SearchItembyName);
            this.ItemOverview.Controls.Add(this.textBox1);
            this.ItemOverview.Controls.Add(this.label2);
            this.ItemOverview.Controls.Add(this.ItemListBox);
            this.ItemOverview.Controls.Add(this.ShowAllItems);
            this.ItemOverview.Location = new System.Drawing.Point(4, 34);
            this.ItemOverview.Name = "ItemOverview";
            this.ItemOverview.Padding = new System.Windows.Forms.Padding(3);
            this.ItemOverview.Size = new System.Drawing.Size(1035, 781);
            this.ItemOverview.TabIndex = 0;
            this.ItemOverview.Text = "ItemOverview";
            this.ItemOverview.UseVisualStyleBackColor = true;
            // 
            // RefreshNumberOfItems
            // 
            this.RefreshNumberOfItems.Location = new System.Drawing.Point(17, 228);
            this.RefreshNumberOfItems.Name = "RefreshNumberOfItems";
            this.RefreshNumberOfItems.Size = new System.Drawing.Size(139, 33);
            this.RefreshNumberOfItems.TabIndex = 6;
            this.RefreshNumberOfItems.Text = "Refresh";
            this.RefreshNumberOfItems.UseVisualStyleBackColor = true;
            this.RefreshNumberOfItems.Click += new System.EventHandler(this.RefreshNumberOfItems_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Number of items: ";
            // 
            // SearchItembyName
            // 
            this.SearchItembyName.Location = new System.Drawing.Point(293, 33);
            this.SearchItembyName.Name = "SearchItembyName";
            this.SearchItembyName.Size = new System.Drawing.Size(133, 31);
            this.SearchItembyName.TabIndex = 4;
            this.SearchItembyName.Text = "Search";
            this.SearchItembyName.UseVisualStyleBackColor = true;
            this.SearchItembyName.Click += new System.EventHandler(this.SearchItembyName_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search item";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 25;
            this.ItemListBox.Location = new System.Drawing.Point(432, 2);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(607, 779);
            this.ItemListBox.TabIndex = 1;
            // 
            // ShowAllItems
            // 
            this.ShowAllItems.Location = new System.Drawing.Point(0, 86);
            this.ShowAllItems.Name = "ShowAllItems";
            this.ShowAllItems.Size = new System.Drawing.Size(432, 62);
            this.ShowAllItems.TabIndex = 0;
            this.ShowAllItems.Text = "Show all items";
            this.ShowAllItems.UseVisualStyleBackColor = true;
            this.ShowAllItems.Click += new System.EventHandler(this.ShowAllItems_Click);
            // 
            // CreateItems
            // 
            this.CreateItems.Controls.Add(this.button3);
            this.CreateItems.Controls.Add(this.textBox4);
            this.CreateItems.Controls.Add(this.textBox3);
            this.CreateItems.Controls.Add(this.textBox2);
            this.CreateItems.Controls.Add(this.label5);
            this.CreateItems.Controls.Add(this.label4);
            this.CreateItems.Controls.Add(this.label3);
            this.CreateItems.Location = new System.Drawing.Point(4, 34);
            this.CreateItems.Name = "CreateItems";
            this.CreateItems.Padding = new System.Windows.Forms.Padding(3);
            this.CreateItems.Size = new System.Drawing.Size(1035, 781);
            this.CreateItems.TabIndex = 1;
            this.CreateItems.Text = "CreateItems";
            this.CreateItems.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(455, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Create item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(212, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(283, 31);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 31);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name of the item";
            // 
            // DeleteItems
            // 
            this.DeleteItems.Controls.Add(this.button5);
            this.DeleteItems.Controls.Add(this.button4);
            this.DeleteItems.Controls.Add(this.textBox5);
            this.DeleteItems.Controls.Add(this.label6);
            this.DeleteItems.Controls.Add(this.listBox1);
            this.DeleteItems.Location = new System.Drawing.Point(4, 34);
            this.DeleteItems.Name = "DeleteItems";
            this.DeleteItems.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteItems.Size = new System.Drawing.Size(1035, 781);
            this.DeleteItems.TabIndex = 2;
            this.DeleteItems.Text = "DeleteItems";
            this.DeleteItems.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(432, 62);
            this.button5.TabIndex = 6;
            this.button5.Text = "Delete selected item";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(296, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(284, 31);
            this.textBox5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search item";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(432, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(607, 779);
            this.listBox1.TabIndex = 2;
            // 
            // UpdateItems
            // 
            this.UpdateItems.Location = new System.Drawing.Point(4, 34);
            this.UpdateItems.Name = "UpdateItems";
            this.UpdateItems.Size = new System.Drawing.Size(1035, 781);
            this.UpdateItems.TabIndex = 3;
            this.UpdateItems.Text = "UpdateItems";
            this.UpdateItems.UseVisualStyleBackColor = true;
            // 
            // WarehouseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 821);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WarehouseManager";
            this.Text = "ItemManager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.WarehouseOverview.ResumeLayout(false);
            this.ItemOverview.ResumeLayout(false);
            this.ItemOverview.PerformLayout();
            this.CreateItems.ResumeLayout(false);
            this.CreateItems.PerformLayout();
            this.DeleteItems.ResumeLayout(false);
            this.DeleteItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RadioButton ItemOverviewRBT;
        private Panel panel2;
        private Label label1;
        private RadioButton DeleteItemsRBT;
        private RadioButton CreateItemsRBT;
        private RadioButton UpdateItemsRBT;
        private TabControl tabControl1;
        private TabPage ItemOverview;
        private TabPage CreateItems;
        private TabPage DeleteItems;
        private TabPage UpdateItems;
        private Button SearchItembyName;
        private TextBox textBox1;
        private Label label2;
        private ListBox ItemListBox;
        private Button ShowAllItems;
        private Button RefreshNumberOfItems;
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
        private ListBox ItemList;
        private ListBox warehouseListbox;
    }
}