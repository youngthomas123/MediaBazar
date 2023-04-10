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

namespace S2GroupProject.Forms
{
    public partial class WarehouseManager : Form
    {
        public Warehouse warehouse = new Warehouse();
        public WarehouseManager()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
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
            foreach(Item item in warehouse.GetItems())
            {
                ItemListBox.Items.Add(item);
            }
            int NumberOfItems = warehouse.GetItems().Count;
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
                    int newQuantity = Convert.ToInt32(textBox6.Text.Trim());

                    // Validate the user input
                    if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newDescription) || newQuantity <= 0)
                    {
                        MessageBox.Show("Please enter valid values for the updated properties.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Update the item properties
                        item.Name = newName;
                        item.Description = newDescription;
                        item.Quantity = newQuantity;
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
            int quantity = Convert.ToInt32(textBox4.Text);

            Item item = new Item(name, description, quantity);
            warehouse.AddItems(item);
        }
    }
}
