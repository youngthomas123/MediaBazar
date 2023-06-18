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
			ItemDataGrid = new DataGridView();
			((System.ComponentModel.ISupportInitialize)ItemDataGrid).BeginInit();
			SuspendLayout();
			// 
			// ItemDataGrid
			// 
			ItemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ItemDataGrid.Location = new Point(61, 113);
			ItemDataGrid.Name = "ItemDataGrid";
			ItemDataGrid.RowHeadersWidth = 62;
			ItemDataGrid.RowTemplate.Height = 33;
			ItemDataGrid.Size = new Size(627, 241);
			ItemDataGrid.TabIndex = 0;
			ItemDataGrid.CellContentClick += ItemDataGrid_CellContentClick;
			ItemDataGrid.ColumnHeaderMouseClick += ItemDataGrid_ColumnHeaderMouseClick;
			// 
			// Experiment
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1676, 1213);
			Controls.Add(ItemDataGrid);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Experiment";
			Text = "Experiment";
			((System.ComponentModel.ISupportInitialize)ItemDataGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView ItemDataGrid;
	}
}