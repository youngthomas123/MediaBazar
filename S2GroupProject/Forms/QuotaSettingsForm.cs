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
    public partial class QuotaSettingsForm : Form
    {
        private readonly IEmployeeContainer _employeeContainer;
        public QuotaSettingsForm(IEmployeeContainer employeeContainer)
        {
            InitializeComponent();
            _employeeContainer = employeeContainer;
           
            List<TextBox> textBoxes = new List<TextBox>
            {
                textBox7,
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6
                
            };

            Dictionary<DayOfWeek, int> quotas = _employeeContainer.LoadQuotas();

            foreach (KeyValuePair<DayOfWeek, int> quota in quotas)
            {
                TextBox textBox = textBoxes[(int)quota.Key];
                textBox.Text = quota.Value.ToString();
            }
        }

        private void updateQuotasBtn_Click(object sender, EventArgs e)
        {
            Dictionary<DayOfWeek, int> dailyQuotas = new Dictionary<DayOfWeek, int>
            {
                { DayOfWeek.Monday, Convert.ToInt32(textBox1.Text)},
                { DayOfWeek.Tuesday, Convert.ToInt32(textBox2.Text) },
                { DayOfWeek.Wednesday, Convert.ToInt32(textBox3.Text) },
                {DayOfWeek.Thursday, Convert.ToInt32(textBox4.Text) },
                {DayOfWeek.Friday, Convert.ToInt32(textBox5.Text) },
                {DayOfWeek.Saturday, Convert.ToInt32(textBox6.Text) },
                {DayOfWeek.Sunday, Convert.ToInt32(textBox7.Text) }
            };

            _employeeContainer.UpdateQuotas(dailyQuotas);
        }
    }
}
