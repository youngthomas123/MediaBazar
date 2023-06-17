using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
	public partial class Experiment : Form
	{
		private readonly IEmployeeContainer _employeeContainer;
		public Experiment(IEmployeeContainer employeeContainer)
		{
			_employeeContainer = employeeContainer;
			InitializeComponent();
			FillLayoutPanel();
		}
		public void LoadingData2()
		{
			List<Employee> emps = new List<Employee>();

			emps = _employeeContainer.LoadEmployees();
			
		}

		public void FillLayoutPanel()
		{
			List<Employee> emps = new List<Employee>();

			emps = _employeeContainer.LoadEmployees();
			foreach (var emp in emps)
			{
				EmployeeUC empUC = new EmployeeUC(emp, _employeeContainer);
				EmployeeFlowPanel.Controls.Add(empUC);
			}
		}

		private void EmployeeFlowPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
