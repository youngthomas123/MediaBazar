namespace S2GroupProject.Forms
{
    partial class CreateWarehousePopUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.warehouseNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.warehouseAddressTB = new System.Windows.Forms.TextBox();
            this.addWarehouseBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse name: ";
            // 
            // warehouseNameTB
            // 
            this.warehouseNameTB.Location = new System.Drawing.Point(188, 47);
            this.warehouseNameTB.Name = "warehouseNameTB";
            this.warehouseNameTB.Size = new System.Drawing.Size(144, 23);
            this.warehouseNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Warehouse address: ";
            // 
            // warehouseAddressTB
            // 
            this.warehouseAddressTB.Location = new System.Drawing.Point(188, 105);
            this.warehouseAddressTB.Name = "warehouseAddressTB";
            this.warehouseAddressTB.Size = new System.Drawing.Size(144, 23);
            this.warehouseAddressTB.TabIndex = 3;
            // 
            // addWarehouseBTN
            // 
            this.addWarehouseBTN.Location = new System.Drawing.Point(52, 144);
            this.addWarehouseBTN.Name = "addWarehouseBTN";
            this.addWarehouseBTN.Size = new System.Drawing.Size(280, 29);
            this.addWarehouseBTN.TabIndex = 4;
            this.addWarehouseBTN.Text = "Add Warehouse";
            this.addWarehouseBTN.UseVisualStyleBackColor = true;
            this.addWarehouseBTN.Click += new System.EventHandler(this.addWarehouseBTN_Click);
            // 
            // CreateWarehousePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addWarehouseBTN);
            this.Controls.Add(this.warehouseAddressTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warehouseNameTB);
            this.Controls.Add(this.label1);
            this.Name = "CreateWarehousePopUp";
            this.Text = "CreateWarehousePopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox warehouseNameTB;
        private Label label2;
        private TextBox warehouseAddressTB;
        private Button addWarehouseBTN;
    }
}