using MediaBazarLib;
using S2GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2GroupProject.Forms
{
    public partial class ItemsPopUp : Form
    {
        public ItemsPopUp()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Global.myManagement.AddItem(itemNameTB.Text, descriptionRTB.Text, Convert.ToInt32(quantityTB.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = searchTB.Text;
            Item searchedItem = Global.myManagement.GetItem(name);
            if (searchedItem != null)
            {
                ItemList.Items.Clear();
                ItemList.Items.Add(searchedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemList.Items.Clear();
            foreach (Item i in Global.myManagement.GetItems())
            {
                ItemList.Items.Add(i);
            }
            
        }

        private void removeSelectedItemBT_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ItemList.SelectedItem;
            if (selectedItem != null)
            {
                Global.myManagement.RemoveItem(selectedItem);
                ItemList.Items.Remove(selectedItem);
            }
        }
    }
}
