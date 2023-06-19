using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace S2GroupProject.Forms
{
	public partial class Experiment : Form
	{
		private readonly IEmployeeContainer _employeeContainer;
		private readonly IItemContainer _itemContainer;
		public Experiment(IEmployeeContainer employeeContainer, IItemContainer itemContainer)
		{
			_employeeContainer = employeeContainer;
			InitializeComponent();
			FillLayoutPanel();
			_itemContainer = itemContainer;
			LoadingData2();
		}
		public void LoadingData2()
		{
			List<Item> items = new List<Item>();
			items = _itemContainer.LoadItem();

			SortableBindingList<Item> sortableItems = new SortableBindingList<Item>(items);

			ItemDataGrid.AutoGenerateColumns = false;
			DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
			nameColumn.HeaderText = "Name";
			nameColumn.DataPropertyName = "Name";
			ItemDataGrid.Columns.Add(nameColumn);

			DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
			priceColumn.HeaderText = "Price €";
			priceColumn.DataPropertyName = "Price";
			ItemDataGrid.Columns.Add(priceColumn);

			DataGridViewTextBoxColumn warehouseQuantityCol = new DataGridViewTextBoxColumn();
			warehouseQuantityCol.HeaderText = "Warehouse Quantity";
			warehouseQuantityCol.DataPropertyName = "WarehouseQuantity";
			ItemDataGrid.Columns.Add(warehouseQuantityCol);

			DataGridViewTextBoxColumn shopQuantityCol = new DataGridViewTextBoxColumn();
			shopQuantityCol.HeaderText = "Shop Quantity";
			shopQuantityCol.DataPropertyName = "ShopQuantity";
			ItemDataGrid.Columns.Add(shopQuantityCol);


			ItemDataGrid.DataSource = sortableItems;

			Panel panel = new Panel();
			panel.Dock = DockStyle.Fill;
			panel.AutoScroll = true;
			panel.Controls.Add(ItemDataGrid);

			// Add the Panel to the form or container control
			Controls.Add(panel);


			ItemDataGrid.ColumnHeaderMouseClick += ItemDataGrid_ColumnHeaderMouseClick;

			//List<Employee> emps = new List<Employee>();
			//emps = _employeeContainer.LoadEmployees();

		}

		public void FillLayoutPanel()
		{
			//List<Employee> emps = new List<Employee>();

			//emps = _employeeContainer.LoadEmployees();
			//foreach (var emp in emps)
			//{
			//	EmployeeUC empUC = new EmployeeUC(emp, _employeeContainer);
			//	EmployeeFlowPanel.Controls.Add(empUC);
			//}
		}

		private void ItemDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ItemDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn clickedColumn = ItemDataGrid.Columns[e.ColumnIndex];

			// Determine the sort direction based on the current column sort mode
			ListSortDirection sortDirection = clickedColumn.HeaderCell.SortGlyphDirection == SortOrder.Ascending
				? ListSortDirection.Descending
				: ListSortDirection.Ascending;

			// Sort the grid based on the clicked column and direction
			ItemDataGrid.Sort(clickedColumn, sortDirection);

			// Update the sort glyph display
			ItemDataGrid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = sortDirection == ListSortDirection.Ascending
				? SortOrder.Ascending
				: SortOrder.Descending;
		}
	}
}
