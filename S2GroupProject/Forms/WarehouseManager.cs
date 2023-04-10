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
                UpdateItems.Hide();
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
                UpdateItems.Hide();
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
                UpdateItems.Hide();
            }
        }

        private void UpdateItemsRBT_CheckedChanged(object sender, EventArgs e)
        {

            if (UpdateItemsRBT.Checked == true)
            {
                UpdateItems.Show();
                ItemOverview.Hide();
                CreateItems.Hide();
                DeleteItems.Hide();
                WarehouseOverview.Hide();
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
                UpdateItems.Hide();
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

        }



        
    }
}
