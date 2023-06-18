using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace S2GroupProject.Forms
{
	public partial class WarehouseManager : Form
	{

		private readonly IServiceProvider _serviceProvider;
		private readonly IEmployeeContainer _employeeContainer;
		private readonly IItemContainer _itemContainer;
		private readonly IWarehouseContainer _warehouseContainer;

		List<Item> items = new List<Item>();
		List<Employee> employees = new List<Employee>();
		List<Warehouse> warehouses = new List<Warehouse>();
		List<string> categories = new List<string>();

		public WarehouseManager(IServiceProvider serviceProvider, IItemContainer itemContainer, IEmployeeContainer employeeContainer, IWarehouseContainer warehouseContainer)
		{
			_serviceProvider = serviceProvider;
			_employeeContainer = employeeContainer;
			_itemContainer = itemContainer;
			_warehouseContainer = warehouseContainer;
			InitializeComponent();
			LoadData();
			LoadDataGrid();
			WarehouseRestockData();
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
		}

		public void LoadData()
		{
			warehouseListbox.Items.Clear();
			employeeList.Items.Clear();
			listBox1.Items.Clear();
			ShopRequests.Items.Clear();
			warehouseComboBox.Items.Clear();
			warehouseComboBox2.Items.Clear();
			CategoriesBox.Items.Clear();
			categoryBox2.Items.Clear();

			warehouses = _warehouseContainer.LoadWarehouse();
			items = _itemContainer.LoadItem();
			employees = _employeeContainer.LoadEmployees();
			categories = _itemContainer.GetCategories();


			foreach (Item item in items)
			{
				listBox1.Items.Add(item);
			}
			foreach (Employee employee in employees)
			{
				employeeList.Items.Add(employee);
			}
			foreach (Warehouse warehouse in warehouses)
			{
				warehouseListbox.Items.Add(warehouse);
				warehouseComboBox.Items.Add(warehouse);
				warehouseComboBox2.Items.Add(warehouse);
			}
			foreach (string category in categories)
			{
				CategoriesBox.Items.Add(category);
				categoryBox2.Items.Add(category);
			}
		}

		public void LoadDataGrid()
		{
			ItemDataGrid.Rows.Clear();

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

			panel3.AutoScroll = true;

			foreach (DataGridViewColumn column in ItemDataGrid.Columns)
			{
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				column.FillWeight = 100f / ItemDataGrid.Columns.Count;
			}

			// Deselect any selected rows
			ItemDataGrid.ClearSelection();

			ItemDataGrid.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
		}

		public void WarehouseRestockData()
		{
			WarehouseItemRestocking.Items.Clear();
			items = _itemContainer.LoadItem();
			foreach (Item item in items)
			{
				if (item.WarehouseQuantity <= 50)
				{
					WarehouseItemRestocking.Items.Add(item);
				}
			}
		}



		public void RefreshData()
		{
			LoadData();
			LoadDataGrid();
		}


		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ItemOverviewRBT_CheckedChanged(object sender, EventArgs e)
		{

			if (ItemOverviewRBT.Checked == true)
			{
				
				ItemOverview.Show();
				WarehouseOverview.Hide();
				CreateItems.Hide();
				DeleteItems.Hide();
			}

		}

		private void CreateItemsRBT_CheckedChanged(object sender, EventArgs e)
		{
			if (CreateItemsRBT.Checked == true)
			{
				CreateItems.Show();
				WarehouseOverview.Hide();
				ItemOverview.Hide();
				DeleteItems.Hide();
			}
		}

		private void DeleteItemsRBT_CheckedChanged(object sender, EventArgs e)
		{

			if (DeleteItemsRBT.Checked == true)
			{
				DeleteItems.Show();
				WarehouseOverview.Hide();
				ItemOverview.Hide();
				CreateItems.Hide();
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				WarehouseOverview.Show();
				ItemOverview.Hide();
				CreateItems.Hide();
				DeleteItems.Hide();
			}
		}
		private void WarehouseEmployeeRBT_CheckedChanged(object sender, EventArgs e)
		{
			if (WarehouseEmployeeRBT.Checked == true)
			{
				WarehouseOverview.Hide();
				ItemOverview.Hide();
				CreateItems.Hide();
				DeleteItems.Hide();
				WarehouseEmployees.Show();
			}
		}

		private void SearchItembyName_Click(object sender, EventArgs e)
		{
			try
			{
				string keyword = textBox1.Text;
				var foundItems = _itemContainer.SearchPostsByKeyword(keyword);
				foreach (var item in foundItems)
				{

				}
			}
			catch (NotImplementedException) { MessageBox.Show("Item not found"); }

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ItemDataGrid.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = ItemDataGrid.SelectedRows[0];
				Item selectedItem = (Item)selectedRow.DataBoundItem;

				string newName = textBox8.Text.Trim();
				string newDescription = textBox7.Text.Trim();
				decimal price;
				if (textBox3.Text == "")
				{
					price = 0;
				}
				else
				{
					price = decimal.Parse(textBox3.Text.Trim());
				}

				if (selectedItem != null)
				{
					if(newName != "" && newDescription == "" && price == 0)
					{
						_itemContainer.UpdateItemName(selectedItem, newName);
					}
					if(price != 0 && newName == "" && newDescription == "")
					{
						_itemContainer.UpdateItemPrice(selectedItem, price);
					}
					if(newDescription != "" && newName == "" && price == 0)
					{
						_itemContainer.UpdateItemDescription(selectedItem, newDescription);
					}
					if(price != 0 && newDescription != "" && newName != "")
					{
						_itemContainer.UpdateItemDescription(selectedItem, newDescription);
						_itemContainer.UpdateItemName(selectedItem, newName);
						_itemContainer.UpdateItemPrice(selectedItem, price);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select an item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Check if a category is selected
			if (categoryBox2.SelectedIndex != -1)
			{
				// Retrieve the selected category index or value
				int categorySelected = categoryBox2.SelectedIndex;
				categorySelected++;
				// Alternatively, you can retrieve the selected category value using CategoriesBox.SelectedItem

				// Retrieve other item details from the input controls
				string name = textBox2.Text;
				string description = descriptionTB.Text;
				int warehouseQuantity = Convert.ToInt32(quantityTB.Text);
				int shopquantity = Convert.ToInt32(textBox9.Text);
				decimal price = Convert.ToDecimal(priceTB.Text);

				// Create the new item using the selected category and other details
				Item newItem = new Item(Guid.NewGuid(), name, description, warehouseQuantity, shopquantity, categorySelected, price);
				_itemContainer.AddItem(newItem);

				// Optionally, perform additional processing or display success message
				MessageBox.Show("Item created successfully!");
			}
			else
			{
				// Category is not selected, display an error message or handle the scenario accordingly
				MessageBox.Show("Please select a category.");
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			CreateWarehousePopUp createWarehouse = _serviceProvider.GetService<CreateWarehousePopUp>();
			createWarehouse.ShowDialog();
		}

		private void warehouseListbox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void RefreshDataBTN_Click(object sender, EventArgs e)
		{
			RefreshData();
			WarehouseRestockData();
		}

		private void AssignItemBTN_Click(object sender, EventArgs e)
		{
			//Item selectedItem = (Item)ItemListBox.SelectedItem;
			//Warehouse selectedWarehouse = (Warehouse)warehouseComboBox.SelectedItem;
			//if (selectedItem != null && selectedWarehouse != null)
			//{
			//	_warehouseContainer.AssignItemToWarehouse(selectedItem.Id, selectedWarehouse.Id);

			//}
			//else
			//{ MessageBox.Show("Please select an item/warehouse!"); }
		}

		private void ViewDataBTN_Click(object sender, EventArgs e)
		{
			Warehouse selectedWarehouse = (Warehouse)warehouseListbox.SelectedItem;
			if (selectedWarehouse != null)
			{
				warehouseListbox.Items.Clear();
				List<Item> warehouseItems = _warehouseContainer.LoadWarehouseItems(selectedWarehouse.Id);

				foreach (Item item in warehouseItems)
				{
					warehouseListbox.Items.Add(item);
				}
			}
			else
			{
				MessageBox.Show("Select a warehouse first");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Item selectedItem = (Item)listBox1.SelectedItem;
			if (selectedItem != null)
			{
				_itemContainer.DeleteItem(selectedItem);
				RefreshData();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				listBox1.Items.Clear();
				string keyword = textBox5.Text;
				var foundItems = _itemContainer.SearchPostsByKeyword(keyword);
				foreach (var item in foundItems)
				{
					listBox1.Items.Add(item);
				}
			}
			catch (NotImplementedException) { MessageBox.Show("Item not found"); }
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			//WarehouseManager itemManager = _serviceProvider.GetService<WarehouseManager>();
			//this.Close();
			//LoginForm loginForm = _serviceProvider.GetService<LoginForm>();
			//loginForm.Show();
		}

		private void AssignEmployeeToWarehouseBTN_Click(object sender, EventArgs e)
		{
			Employee selectedEmployee = (Employee)employeeList.SelectedItem;
			Warehouse selectedWarehouse = (Warehouse)warehouseComboBox2.SelectedItem;
			if (selectedEmployee != null && selectedWarehouse != null)
			{
				_warehouseContainer.AssignEmployeeToWarehouse(selectedEmployee.BSN, selectedWarehouse.Id);

			}
			else
			{ MessageBox.Show("Please select an employee/warehouse!"); }
		}

		private void ShowWarehouseEmployeesBTN_Click(object sender, EventArgs e)
		{
			Warehouse selectedWarehouse = (Warehouse)warehouseListbox.SelectedItem;
			if (selectedWarehouse != null)
			{
				warehouseListbox.Items.Clear();
				List<Employee> warehouseEmployees = _warehouseContainer.LoadWarehouseEmployees(selectedWarehouse.Id);

				foreach (Employee employee in warehouseEmployees)
				{
					warehouseListbox.Items.Add(employee);
				}
			}
			else
			{
				MessageBox.Show("Select a warehouse first");
			}
		}

		private void Restock_Click(object sender, EventArgs e)
		{
			Item selectedItemForRestock = (Item)WarehouseItemRestocking.SelectedItem;
			if (selectedItemForRestock != null)
			{
				_itemContainer.UpdateItemQuantity(selectedItemForRestock, 200);
			}
			WarehouseRestockData();
		}

		private void CategoriesBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Get the selected category index from the combo box
			int selectedCategoryIndex = CategoriesBox.SelectedIndex;
			selectedCategoryIndex++;

			// Get the original data source of the DataGridView
			var originalItems = (SortableBindingList<Item>)ItemDataGrid.DataSource;

			// Convert the SortableBindingList to a DataTable
			DataTable dataTable = ConvertToDataTable(originalItems);

			// Create a DataView from the DataTable
			DataView dataView = new DataView(dataTable);

			// Apply the filter based on the selected category index
			dataView.RowFilter = $"Category = {selectedCategoryIndex}";

			// Convert the filtered DataView rows back to Item objects
			var filteredItems = dataView.Cast<DataRowView>()
				.Select(rowView =>
				{
					DataRow row = rowView.Row;
					return new Item(
						(Guid)row["Id"],
						(string)row["Name"],
						(string)row["Description"],
						(int)row["WarehouseQuantity"],
						(int)row["ShopQuantity"],
						(int)row["Category"],
						(decimal)row["Price"]
					);
				})
				.ToList();

			// Create a new SortableBindingList<Item> from the filtered items
			var filteredItemList = new SortableBindingList<Item>(filteredItems);

			// Bind the filtered SortableBindingList<Item> to the DataGridView
			ItemDataGrid.DataSource = filteredItemList;


		}
		private DataTable ConvertToDataTable<T>(IEnumerable<T> data)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			DataTable dataTable = new DataTable();

			foreach (PropertyDescriptor prop in properties)
				dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

			foreach (T item in data)
			{
				DataRow row = dataTable.NewRow();

				foreach (PropertyDescriptor prop in properties)
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

				dataTable.Rows.Add(row);
			}

			return dataTable;
		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void categoryBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string searchQuery = textBox1.Text.ToLower();


			foreach (DataGridViewRow row in ItemDataGrid.Rows)
			{
				if (!row.IsNewRow) // Skip the uncommitted new row
				{
					DataGridViewCell cell = row.Cells[0];
					if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchQuery))
					{
						row.Visible = true;
					}
					else
					{
						// Check if the row is selected or in focus
						if (row.Selected || row.Cells[0].Selected)
						{
							ItemDataGrid.CurrentCell = null; // Deselect the row
						}

						row.Visible = false;
					}
				}
			}
		}

		private void ItemDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
