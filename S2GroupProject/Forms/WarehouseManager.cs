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
    public partial class WarehouseManager : Form
    {
        public WarehouseManager()
        {
            InitializeComponent();
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

        }

        private void SearchItembyName_Click(object sender, EventArgs e)
        {

        }

        private void RefreshNumberOfItems_Click(object sender, EventArgs e)
        {

        }

        
    }
}
