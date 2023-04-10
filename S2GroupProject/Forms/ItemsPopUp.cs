
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
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
        private readonly IItemContainer _itemContainer;
        private readonly IServiceProvider _serviceProvider;

        public ItemsPopUp(IItemContainer itemContainer, IServiceProvider serviceProvider)
        {
            _itemContainer = itemContainer;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _itemContainer.AddItem(itemNameTB.Text, descriptionRTB.Text, Convert.ToInt32(quantityTB.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = searchTB.Text;
            Item searchedItem = _itemContainer.GetItem(name);
            if (searchedItem != null)
            {
                ItemList.Items.Clear();
                ItemList.Items.Add(searchedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemList.Items.Clear();
            foreach (Item i in _itemContainer.GetItems())
            {
                ItemList.Items.Add(i);
            }
            
        }

        private void removeSelectedItemBT_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ItemList.SelectedItem;
            if (selectedItem != null)
            {
                _itemContainer.RemoveItem(selectedItem);
                ItemList.Items.Remove(selectedItem);
            }
        }
    }
}
