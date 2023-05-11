using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.BusinessLogic.Classes;
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
    public partial class CreateWarehousePopUp : Form
    {
        private readonly IWarehouseContainer _warehouseContainer;

        public CreateWarehousePopUp(IWarehouseContainer warehouseContainer)
        {
            _warehouseContainer= warehouseContainer;
            InitializeComponent();
        }

        private void addWarehouseBTN_Click(object sender, EventArgs e)
        {
            string name = warehouseNameTB.Text;
            string address = warehouseAddressTB.Text;
            if(name != "" && address != "")
            {
                Warehouse warehouse = new Warehouse(name, address);
                _warehouseContainer.AddWarehouse(warehouse);
            }
            else
            {
                MessageBox.Show("Please enter a name and an address");
            }
        }
    }
}
