using S2GroupProject.Classes;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static S2GroupProject.Classes.MyEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S2GroupProject
{
	public partial class Form1 : Form
	{
		List<Employee> employees = Global.myManagement.GetEmployees();
		public Form1()
		{
			List<DayOfWeek> DayOfWeeks = new List<DayOfWeek>();
			DayOfWeeks.Add(DayOfWeek.Monday);
			DayOfWeeks.Add(DayOfWeek.Tuesday);

			//daysOffClb = new CheckedListBox();

			
			InitializeComponent();
			
			
			

			Global.myManagement.AddEmployee("Mihail", "Mihov", 1, +359123123, "Nqkudesi",
											ContractTypes.FULL_TIME, 16, JobPositions.STORE_MANAGER, 25, 
											new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }, 19, null, null);
			Global.myManagement.AddEmployee("Panayot", "Panov", 2, +359123123, "Nqkudesi",
									ContractTypes.FULL_TIME, 16, JobPositions.SECURITY, 25, DayOfWeeks, 19, null, null);

			Global.myManagement.AddEmployee("Georgi", "Obretenov", 3, +359123123, "Nqkudesi",
										ContractTypes.FULL_TIME, 16, JobPositions.CASHIER, 25, DayOfWeeks, 19, null, null);

			Global.myManagement.AddEmployee("Tonkata", "", 4, +359123123, "Nqkudesi",
										ContractTypes.FULL_TIME, 16, JobPositions.WAREHOUSE_EMPLOYEE, 25, DayOfWeeks, 19, null, null);
			Global.myManagement.AddEmployee("Nik", "Spek", 5, +359123123, "Nqkudesi",
										ContractTypes.FULL_TIME, 16, JobPositions.WAREHOUSE_MANAGER, 25, DayOfWeeks, 19, null, null);

			Global.myManagement.AddEmployee("Averami", "Gurbami", 6, +359123123, "Nqkudesi",
											ContractTypes.FULL_TIME, 16, JobPositions.STORE_EMPLOYEE, 25, DayOfWeeks, 19, null, null);

			LoadingData();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (employeesLb.SelectedItem != null)
			{
				var popupForm = new Form();

				// Create an instance of your user control
				var myUserControl = new EmployeeUC();

				// Set any properties or values on your user control here
				// ...

				// Add your user control to the form's Controls collection
				popupForm.Controls.Add(myUserControl);

				// Set the properties of the form to make it look like a popup
				popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
				popupForm.StartPosition = FormStartPosition.CenterParent;

				// Display the form as a modal dialog
				popupForm.ShowDialog();
			}
		}

		public void LoadingData()
		{
			foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
			{
				daysOffClb.Items.Add(day.ToString());
			}
			foreach (var jobPosition in Enum.GetValues(typeof(JobPositions)))
			{
				jobPositionCb.Items.Add(jobPosition);
			}

			foreach (var contract in Enum.GetValues(typeof(ContractTypes)))
			{
				contractCb.Items.Add(contract);
			}

			foreach (var employee in Global.myManagement.GetEmployees())
			{
				employeesLb.Items.Add(employee);
			}
		}

		public void RefreshData()
		{
			employeesLb.Items.Clear();
			LoadingData();
		}

		private void AddEmployee_Click(object sender, EventArgs e)
		{
			string firstName = firstNameTb.Text;
			string lastName = lastNameTb.Text;
			int bsn = int.Parse(bsnTb.Text);
			int telNubmer = int.Parse(telNumberTb.Text);
			string address = addressTb.Text;
			ContractTypes contractType = (ContractTypes)contractCb.SelectedItem;
			int workingHoursPerWeek = int.Parse(hoursPerWeekTb.Text);
			JobPositions jobPosition = (JobPositions)jobPositionCb.SelectedItem;
			double wage = double.Parse(wageTb.Text);
			int age = int.Parse(ageTb.Text);
			List<DayOfWeek> daysOff = new List<DayOfWeek>();
			foreach (var checkedItem in daysOffClb.CheckedItems)
			{
				DayOfWeek day;
				if (Enum.TryParse(checkedItem.ToString(), out day))
				{
					daysOff.Add(day);
				}
				
			}

			Global.myManagement.AddEmployee(firstName, lastName, bsn, telNubmer, address, contractType, workingHoursPerWeek, jobPosition, wage, daysOff, age, null, null);

			RefreshData();
		}

		private void RemoveBtn_Click(object sender, EventArgs e)
		{
			int bsn = int.Parse(bsnRemoveTb.Text);
			Employee empToRemove = Global.myManagement.GetEmployeeByBcn(bsn);
			bool isBscnAssigned = employees.Any(e => e.BSN == bsn);

			if (!isBscnAssigned)
			{
				MessageBox.Show($"Can't remove employee due to non-existing BSN");
			}
			else
			{
				

				employees.Remove(empToRemove);
			}

			RefreshData();
		}
	}


}			
		
	
