using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
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
			WarehouseRestockData();
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
		}

		public void LoadData()
		{
			warehouseListbox.Items.Clear();
			employeeList.Items.Clear();
			ItemListBox.Items.Clear();
			listBox1.Items.Clear();
			ShopRequests.Items.Clear();
			warehouseComboBox.Items.Clear();
			warehouseComboBox2.Items.Clear();
			CategoriesBox.Items.Clear();

			warehouses = _warehouseContainer.LoadWarehouse();
			items = _itemContainer.LoadItem();
			employees = _employeeContainer.LoadEmployees();
			categories = _itemContainer.GetCategories();


			foreach (Item item in items)
			{
				ItemListBox.Items.Add(item);
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
			}
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

		private void ShowAllItems_Click(object sender, EventArgs e)
		{
			ItemListBox.Items.Clear();
			foreach (Item item in items)
			{
				ItemListBox.Items.Add(item);
			}
			int NumberOfItems = items.Count;
			label7.Text = $"Number of items: {NumberOfItems}";
		}

		private void SearchItembyName_Click(object sender, EventArgs e)
		{
			try
			{
				ItemListBox.Items.Clear();
				string keyword = textBox1.Text;
				var foundItems = _itemContainer.SearchPostsByKeyword(keyword);
				foreach (var item in foundItems)
				{
					ItemListBox.Items.Add(item);
				}
			}
			catch (NotImplementedException) { MessageBox.Show("Item not found"); }

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ItemListBox.SelectedItem != null)
			{
				try
				{
					Item item = (Item)ItemListBox.SelectedItem;
					string newName = textBox8.Text.Trim();
					string newDescription = textBox7.Text.Trim();

					// Validate the user input
					if (textBox7.Text == "" || textBox8.Text == null)
					{
						MessageBox.Show("Please enter valid values for the updated properties.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						// Update the item properties
						_itemContainer.UpdateItemNameAndDescription(item, newName, newDescription);
						RefreshData();
					}
				}
				catch (FormatException)
				{
					MessageBox.Show("Please enter valid integer value for the Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please select an item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//string name = textBox2.Text;
			//string description = textBox3.Text;
			//int warehouseQuantity = Convert.ToInt32(quantityTB.Text);
			//int shopQuantity = Convert.ToInt32(textBox9.Text);
			//int category = textBox4.Text;

			//Item item = new Item(Guid.NewGuid(), name, description, warehouseQuantity, shopQuantity, category);
			//_itemContainer.AddItem(item);
			//RefreshData();

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
			Item selectedItem = (Item)ItemListBox.SelectedItem;
			Warehouse selectedWarehouse = (Warehouse)warehouseComboBox.SelectedItem;
			if (selectedItem != null && selectedWarehouse != null)
			{
				_warehouseContainer.AssignItemToWarehouse(selectedItem.Id, selectedWarehouse.Id);

			}
			else
			{ MessageBox.Show("Please select an item/warehouse!"); }
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
				ItemListBox.Items.Clear();
				items = _itemContainer.LoadItem();
				string searchedItemName = textBox5.Text;
				foreach (Item item in items)
				{
					if (searchedItemName == item.Name)
					{
						ItemListBox.Items.Add(item);
					}
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
			ItemListBox.Items.Clear();
			int categorySelected = CategoriesBox.SelectedIndex;
			categorySelected++;

			if (categorySelected != null)
			{
				foreach (Item item in items)
				{
					if (item.Category == categorySelected)
					{
						ItemListBox.Items.Add(item);
					}
				}
			}
			else
			{
				MessageBox.Show("Choose a ctegory");
			}
		}

		private void SortByName_Click(object sender, EventArgs e)
		{
			ItemListBox.Items.Clear();
			Sorting sortbyName = new Sorting();
			var sortedItems = sortbyName.InsertionSort(items);
			foreach (Item item in sortedItems)
			{
				ItemListBox.Items.Add(item);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
