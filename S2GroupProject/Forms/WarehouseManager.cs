using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;

namespace S2GroupProject.Forms
{
    public partial class WarehouseManager : Form
    {
		private readonly IEmployeeContainer _employeeContainer;
		private readonly IItemContainer _itemContainer;

        List<Item> items = new List<Item>();
		List<Employee> employees = new List<Employee>();

		public Warehouse warehouse = new Warehouse("Warehouse 1", "street 1");
        public WarehouseManager(IItemContainer itemContainer, IEmployeeContainer employeeContainer)
        {
			_employeeContainer = employeeContainer;
			_itemContainer = itemContainer;
			InitializeComponent();
            LoadData();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        public void LoadData()
        {
            warehouseListbox.Items.Clear();
            ItemList.Items.Clear();
            employeeList.Items.Clear();
            ItemListBox.Items.Clear();
            listBox1.Items.Clear();

            items = _itemContainer.LoadItem();
			employees = _employeeContainer.LoadEmployees();

            foreach (Item item in items)
            {
                ItemListBox.Items.Add(item);
                listBox1.Items.Add(item);
            }
            foreach(Employee employee in employees)
            {
                employeeList.Items.Add(employee);
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

            if(ItemOverviewRBT.Checked == true)
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

        private void ShowAllItems_Click(object sender, EventArgs e)
        {
            ItemListBox.Items.Clear();
            foreach(Item item in items)
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
                string searchedItemName = textBox1.Text;
                foreach (Item item in warehouse.GetItems())
                {
                    if (searchedItemName == item.Name)
                    {
                        ItemListBox.Items.Add(item);

                    }
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
                    string newQuantity = textBox6.Text.Trim();

                    // Validate the user input
                    if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newDescription))
                    {
                        MessageBox.Show("Please enter valid values for the updated properties.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Update the item properties
                        item.Name = newName;
                        item.Description = newDescription;
                        item.Category = newQuantity;
                        MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string name = textBox2.Text;
            string description = textBox3.Text;
            string category = textBox4.Text;

            Item item = new Item(name, description, category);
            _itemContainer.AddItem(item);
            RefreshData();

        }
    }
}
