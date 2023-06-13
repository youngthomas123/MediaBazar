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
    public partial class LeaveMessageUC : UserControl
    {
       private readonly IEmployeeContainer _empContainer;
        SickLeave sickLeave;
        Employee emp;
        public LeaveMessageUC(SickLeave sickLeave,Employee emp , IEmployeeContainer employeeContainer)
        {
            InitializeComponent();
            _empContainer = employeeContainer;
            this.sickLeave = sickLeave;
            this.emp = emp;
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            sickLeave.ManagerMessage = messagetb.Text;
            _empContainer.UpdateEmployeSickLeaveManagerMessage(sickLeave, emp);
            MessageBox.Show("Your message has been sent to the Employee");
        }
    }
}
