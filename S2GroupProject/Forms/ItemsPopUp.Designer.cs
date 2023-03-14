namespace S2GroupProject.Forms
{
    partial class ItemsPopUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemNameTB = new System.Windows.Forms.TextBox();
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeSelectedItemBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddItemButton);
            this.groupBox1.Controls.Add(this.quantityTB);
            this.groupBox1.Controls.Add(this.descriptionRTB);
            this.groupBox1.Controls.Add(this.itemNameTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // itemNameTB
            // 
            this.itemNameTB.Location = new System.Drawing.Point(91, 48);
            this.itemNameTB.Name = "itemNameTB";
            this.itemNameTB.Size = new System.Drawing.Size(340, 31);
            this.itemNameTB.TabIndex = 3;
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(134, 113);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.Size = new System.Drawing.Size(333, 133);
            this.descriptionRTB.TabIndex = 4;
            this.descriptionRTB.Text = "";
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(112, 286);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(152, 31);
            this.quantityTB.TabIndex = 5;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(277, 268);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(190, 49);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 25;
            this.ItemList.Location = new System.Drawing.Point(540, 30);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(813, 854);
            this.ItemList.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.searchTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(29, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "See Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search item via name";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(212, 37);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(237, 31);
            this.searchTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "See all items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeSelectedItemBT);
            this.groupBox3.Location = new System.Drawing.Point(29, 639);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove item";
            // 
            // removeSelectedItemBT
            // 
            this.removeSelectedItemBT.Location = new System.Drawing.Point(228, 104);
            this.removeSelectedItemBT.Name = "removeSelectedItemBT";
            this.removeSelectedItemBT.Size = new System.Drawing.Size(259, 52);
            this.removeSelectedItemBT.TabIndex = 0;
            this.removeSelectedItemBT.Text = "Remove selected item";
            this.removeSelectedItemBT.UseVisualStyleBackColor = true;
            this.removeSelectedItemBT.Click += new System.EventHandler(this.removeSelectedItemBT_Click);
            // 
            // ItemsPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 911);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemsPopUp";
            this.Text = "ItemsPopUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button AddItemButton;
        private TextBox quantityTB;
        private RichTextBox descriptionRTB;
        private TextBox itemNameTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox ItemList;
        private GroupBox groupBox2;
        private Label label4;
        private Button button2;
        private Button button1;
        private TextBox searchTB;
        private GroupBox groupBox3;
        private Button removeSelectedItemBT;
    }
}