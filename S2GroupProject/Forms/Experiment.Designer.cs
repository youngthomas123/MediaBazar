namespace S2GroupProject.Forms
{
	partial class Experiment
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
			EmployeeFlowPanel = new FlowLayoutPanel();
			ItemsGridView = new DataGridView();
			Name = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			WarehouseQuantity = new DataGridViewTextBoxColumn();
			ShopQuantity = new DataGridViewTextBoxColumn();
			EmployeeFlowPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ItemsGridView).BeginInit();
			SuspendLayout();
			// 
			// EmployeeFlowPanel
			// 
			EmployeeFlowPanel.Controls.Add(ItemsGridView);
			EmployeeFlowPanel.Location = new Point(4, 8);
			EmployeeFlowPanel.Margin = new Padding(4, 5, 4, 5);
			EmployeeFlowPanel.Name = "EmployeeFlowPanel";
			EmployeeFlowPanel.Size = new Size(1664, 1200);
			EmployeeFlowPanel.TabIndex = 0;
			EmployeeFlowPanel.Paint += EmployeeFlowPanel_Paint;
			// 
			// ItemsGridView
			// 
			ItemsGridView.AllowUserToOrderColumns = true;
			ItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ItemsGridView.Columns.AddRange(new DataGridViewColumn[] { Name, Price, WarehouseQuantity, ShopQuantity });
			ItemsGridView.Location = new Point(3, 3);
			ItemsGridView.Name = "ItemsGridView";
			ItemsGridView.RowHeadersWidth = 62;
			ItemsGridView.RowTemplate.Height = 33;
			ItemsGridView.Size = new Size(833, 526);
			ItemsGridView.TabIndex = 0;
			// 
			// Name
			// 
			Name.HeaderText = "Name";
			Name.MinimumWidth = 8;
			Name.Name = "Name";
			Name.Width = 150;
			// 
			// Price
			// 
			Price.HeaderText = "Price";
			Price.MinimumWidth = 8;
			Price.Name = "Price";
			Price.Width = 150;
			// 
			// WarehouseQuantity
			// 
			WarehouseQuantity.HeaderText = "Warehouse Quantity";
			WarehouseQuantity.MinimumWidth = 8;
			WarehouseQuantity.Name = "WarehouseQuantity";
			WarehouseQuantity.Width = 150;
			// 
			// ShopQuantity
			// 
			ShopQuantity.HeaderText = "Shop Quantity";
			ShopQuantity.MinimumWidth = 8;
			ShopQuantity.Name = "ShopQuantity";
			ShopQuantity.Width = 150;
			// 
			// Experiment
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1676, 1213);
			Controls.Add(EmployeeFlowPanel);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Experiment";
			Text = "Experiment";
			EmployeeFlowPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ItemsGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel EmployeeFlowPanel;
		private DataGridView ItemsGridView;
		private DataGridViewTextBoxColumn Name;
		private DataGridViewTextBoxColumn Price;
		private DataGridViewTextBoxColumn WarehouseQuantity;
		private DataGridViewTextBoxColumn ShopQuantity;
	}
}