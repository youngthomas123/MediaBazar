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
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace S2GroupProject.Forms
{
    public partial class DaySchedule : UserControl
    {
        private readonly IEmployeeContainer _empContainer;
        JobPositions[] jobPositions = ((JobPositions[])Enum.GetValues(typeof(JobPositions))).Skip(1).ToArray();
        Employee selectedEmployee;
        Dictionary<DayOfWeek, int> dailyQuotas = new Dictionary<DayOfWeek, int>();
        public DaySchedule(IEmployeeContainer employeeContainer, DateTime date)
        {
            InitializeComponent();
            _empContainer = employeeContainer;
            dailyQuotas = _empContainer.LoadQuotas();
            // flowLayoutPanel1.Dock = DockStyle.Top;

            Label dateLabel = new Label();
            dateLabel.Text = date.ToString("dddd, MMMM dd, yyyy");
            dateLabel.Font = new Font(dateLabel.Font.FontFamily, 16, FontStyle.Bold);
            dateLabel.AutoSize = true;
            dateLabel.Margin = new Padding(10, 10, 1000, 0);
            dateLabel.Dock = DockStyle.Top;


            flowLayoutPanel1.Controls.Add(dateLabel);
            foreach (var job in jobPositions)
            {

                // Create a container panel to hold the job panel and buttons panel
                TableLayoutPanel containerPanel = new TableLayoutPanel();
                containerPanel.Size = new Size(1000, 200);
                containerPanel.Margin = new Padding(5, 20, 0, 10);
                containerPanel.BackColor = Color.White;
                containerPanel.ColumnCount = 2;
                containerPanel.AutoScroll= true;
                //containerPanel.AutoSize= true;
                
                // Create the job panel
                FlowLayoutPanel jobPanel = new FlowLayoutPanel();
                jobPanel.AutoSize = true;
                jobPanel.BackColor = Color.White;
                jobPanel.AutoScroll = true;
                jobPanel.WrapContents = true;
                jobPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                Label label = new Label();
                label.Text = job.ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = true;

                jobPanel.Controls.Add(label);

                List<Employee> employeesByJob = _empContainer.GetEmployeesByJobPosition(job);

                DayOfWeek currentDayOfWeek = date.DayOfWeek;
                int quota = dailyQuotas[currentDayOfWeek];
                int count = 0;
                //var regularEmployees = employeesByJob.Where(emp => emp.Jobposition != JobPositions.STORE_MANAGER && emp.Jobposition != JobPositions.WAREHOUSE_MANAGER).ToList();
               // var regularEmployees = employeesByJob.ToList();
                foreach (Employee employee in employeesByJob)
                {
                    if (employee.ShiftsDates.Any(shift => shift.ShiftDate == date))
                    {
                        EmployeePorfileUC employeeControl = new EmployeePorfileUC(employee, _empContainer);
                        employeeControl.MouseDoubleClick += EmployeeControl_MouseDoubleClick;

                        jobPanel.Controls.Add(employeeControl);
                        count++;
                    }
                }

                int additionalEmptyProfiles = Math.Max(0, quota - count);
                if (job != JobPositions.STORE_MANAGER && job != JobPositions.WAREHOUSE_MANAGER)
                {
                    for (int i = 0; i < additionalEmptyProfiles; i++)
                    {
                        EmployeePorfileUC emptyProfile = new EmployeePorfileUC();
                        emptyProfile.BorderStyle = BorderStyle.FixedSingle;
                        jobPanel.Controls.Add(emptyProfile);
                        jobPanel.AutoSize = true;
                        jobPanel.AutoScroll = true;
                    }
                }


                int managersNeeded = (quota * 4) / 10 + 1;

                if (job == JobPositions.STORE_MANAGER || job == JobPositions.WAREHOUSE_MANAGER)
                {
                    //int availableManagers = employeesByJob.Count(emp => emp.Jobposition == job);
                    //managersNeeded = Math.Min(managersNeeded, availableManagers);

                    for (int i = 0; i < managersNeeded; i++)
                    {
                        EmployeePorfileUC managerProfile = new EmployeePorfileUC();
                        managerProfile.BorderStyle = BorderStyle.FixedSingle;
                        jobPanel.Controls.Add(managerProfile);
                        jobPanel.AutoSize = true;
                        jobPanel.AutoScroll = true;
                    }
                }

                List<Employee> availableEmployees = employeesByJob.Where(e => !e.ShiftsDates.Any(s => s.ShiftDate == date) && !e.DaysOff.Contains(date.DayOfWeek)).ToList();
                    // Create the buttons panel
                    FlowLayoutPanel buttonsPanel = new FlowLayoutPanel();
                    buttonsPanel.AutoSize = true;
                    buttonsPanel.FlowDirection = FlowDirection.LeftToRight;

                    Button addShiftBtn = new Button();
                    addShiftBtn.Text = "+";
                    addShiftBtn.AutoSize = true;
                    addShiftBtn.Click += (sender, e) =>
                    {
                        // Create an instance of AddShiftUC
                        AddShiftUC addShiftUC = new AddShiftUC(_empContainer, availableEmployees, date);


                        Form popupForm = new Form();
                        popupForm.Controls.Add(addShiftUC);


                        popupForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                        popupForm.StartPosition = FormStartPosition.CenterScreen;
                        popupForm.Size = addShiftUC.Size;


                        popupForm.ShowDialog();
                        RefreshUI(date);
                    };


                    Button removeShiftBtn = new Button();
                    removeShiftBtn.Text = "-";
                    removeShiftBtn.AutoSize = true;
                    removeShiftBtn.Click += (sender, e) =>
                    {
                        Shift shiftToRemove = (Shift)selectedEmployee.ShiftsDates.FirstOrDefault(s => s.ShiftDate == date);
                        selectedEmployee.ShiftsDates.Remove(shiftToRemove);
                        _empContainer.RemoveEmpShift(selectedEmployee, date);
                        RefreshUI(date);
                    };


                    buttonsPanel.Controls.Add(addShiftBtn);
                    buttonsPanel.Controls.Add(removeShiftBtn);


                    containerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    containerPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    containerPanel.Controls.Add(jobPanel, 0, 0);
                    containerPanel.Controls.Add(buttonsPanel, 1, 0);


                    flowLayoutPanel1.Controls.Add(containerPanel);
                //}
            }
        }
        private void EmployeeControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            selectedEmployee = ((EmployeePorfileUC)sender).employee;

        }

        private void RefreshUI(DateTime date)
        {
            // Clear the existing controls in flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            foreach (var job in jobPositions)
            {
                // Create a container panel to hold the job panel and buttons panel
                TableLayoutPanel containerPanel = new TableLayoutPanel();
                containerPanel.Size = new Size(1000, 200);
                containerPanel.Margin = new Padding(5, 20, 0, 10);
                containerPanel.BackColor = Color.White;
                containerPanel.ColumnCount = 2;
                containerPanel.AutoScroll = true;

                // Create the job panel
                FlowLayoutPanel jobPanel = new FlowLayoutPanel();
                jobPanel.AutoSize = true;
                jobPanel.BackColor = Color.White;
                jobPanel.AutoScroll = true;
                jobPanel.WrapContents = true;
                jobPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                Label label = new Label();
                label.Text = job.ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = true;

                jobPanel.Controls.Add(label);
                List<Employee> employeesByJob = _empContainer.GetEmployeesByJobPosition(job);

                DayOfWeek currentDayOfWeek = date.DayOfWeek;
                int quota = dailyQuotas[currentDayOfWeek];
                int count = 0;
                //var regularEmployees = employeesByJob.Where(emp => emp.Jobposition != JobPositions.STORE_MANAGER && emp.Jobposition != JobPositions.WAREHOUSE_MANAGER).ToList();
                // var regularEmployees = employeesByJob.ToList();
                foreach (Employee employee in employeesByJob)
                {
                    if (employee.ShiftsDates.Any(shift => shift.ShiftDate == date))
                    {
                        EmployeePorfileUC employeeControl = new EmployeePorfileUC(employee, _empContainer);
                        employeeControl.MouseDoubleClick += EmployeeControl_MouseDoubleClick;

                        jobPanel.Controls.Add(employeeControl);
                        count++;
                    }
                }

                int additionalEmptyProfiles = Math.Max(0, quota - count);
                if (job != JobPositions.STORE_MANAGER && job != JobPositions.WAREHOUSE_MANAGER)
                {
                    for (int i = 0; i < additionalEmptyProfiles; i++)
                    {
                        EmployeePorfileUC emptyProfile = new EmployeePorfileUC();
                        emptyProfile.BorderStyle = BorderStyle.FixedSingle;
                        jobPanel.Controls.Add(emptyProfile);
                        jobPanel.AutoSize = true;
                        jobPanel.AutoScroll = true;
                    }
                }

                int managersNeeded = (quota * 4) / 10 + 1;

                if (job == JobPositions.STORE_MANAGER || job == JobPositions.WAREHOUSE_MANAGER)
                {
                    //int availableManagers = employeesByJob.Count(emp => emp.Jobposition == job);
                    //managersNeeded = Math.Min(managersNeeded, availableManagers);

                    for (int i = 0; i < managersNeeded; i++)
                    {
                        EmployeePorfileUC managerProfile = new EmployeePorfileUC();
                        managerProfile.BorderStyle = BorderStyle.FixedSingle;
                        jobPanel.Controls.Add(managerProfile);
                        jobPanel.AutoSize = true;
                        jobPanel.AutoScroll = true;
                    }
                }

                List<Employee> availableEmployees = employeesByJob.Where(e => !e.ShiftsDates.Any(s => s.ShiftDate == date) && !e.DaysOff.Contains(date.DayOfWeek)).ToList();

                // Create the buttons panel
                FlowLayoutPanel buttonsPanel = new FlowLayoutPanel();
                buttonsPanel.AutoSize = true;
                buttonsPanel.FlowDirection = FlowDirection.LeftToRight;

                Button addShiftBtn = new Button();
                addShiftBtn.Text = "+";
                addShiftBtn.AutoSize = true;
                addShiftBtn.Click += (sender, e) =>
                {
                    AddShiftUC addShiftUC = new AddShiftUC(_empContainer, availableEmployees, date);
                    Form popupForm = new Form();
                    popupForm.Controls.Add(addShiftUC);
                    popupForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    popupForm.StartPosition = FormStartPosition.CenterScreen;
                    popupForm.Size = addShiftUC.Size;
                    popupForm.ShowDialog();

                    RefreshUI(date); // Refresh the UI after adding a shift
                };

                Button removeShiftBtn = new Button();
                removeShiftBtn.Text = "-";
                removeShiftBtn.AutoSize = true;
                removeShiftBtn.Click += (sender, e) =>
                {
                    Shift shiftToRemove = (Shift)selectedEmployee.ShiftsDates.FirstOrDefault(s => s.ShiftDate == date);
                    selectedEmployee.ShiftsDates.Remove(shiftToRemove);
                    _empContainer.RemoveEmpShift(selectedEmployee, shiftToRemove.ShiftDate);
                    RefreshUI(date); // Refresh the UI after removing a shift
                };

                buttonsPanel.Controls.Add(addShiftBtn);
                buttonsPanel.Controls.Add(removeShiftBtn);

                containerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                containerPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                containerPanel.Controls.Add(jobPanel, 0, 0);
                containerPanel.Controls.Add(buttonsPanel, 1, 0);

                flowLayoutPanel1.Controls.Add(containerPanel);
            }
        }
        private void UpdateUI(DateTime date)
        {
            foreach (var job in jobPositions)
            {
                // Create a container panel to hold the job panel and buttons panel
                TableLayoutPanel containerPanel = new TableLayoutPanel();
                containerPanel.Size = new Size(1000, 200);
                containerPanel.Margin = new Padding(5, 20, 0, 10);
                containerPanel.BackColor = Color.White;
                containerPanel.ColumnCount = 2;

                // Create the job panel
                FlowLayoutPanel jobPanel = new FlowLayoutPanel();
                jobPanel.AutoSize = true;
                jobPanel.BackColor = Color.White;

                Label label = new Label();
                label.Text = job.ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = true;

                jobPanel.Controls.Add(label);

                var employeesForJob = _empContainer.GetEmployeesByJobPosition(job);

                foreach (var employee in employeesForJob)
                {
                    if (employee.ShiftsDates.Any(shift => shift.ShiftDate == date))
                    {
                        EmployeePorfileUC employeeControl = new EmployeePorfileUC(employee, _empContainer);
                        employeeControl.MouseDoubleClick += EmployeeControl_MouseDoubleClick;

                        jobPanel.Controls.Add(employeeControl);
                    }
                }

                List<Employee> availableEmployees = employeesForJob.Where(e => !e.ShiftsDates.Any(s => s.ShiftDate == date)).ToList();

                // Create the buttons panel
                FlowLayoutPanel buttonsPanel = new FlowLayoutPanel();
                buttonsPanel.AutoSize = true;
                buttonsPanel.FlowDirection = FlowDirection.LeftToRight;

                Button addShiftBtn = new Button();
                addShiftBtn.Text = "+";
                addShiftBtn.AutoSize = true;
                addShiftBtn.Click += (sender, e) =>
                {
                    AddShiftUC addShiftUC = new AddShiftUC(_empContainer, availableEmployees, date);
                    Form popupForm = new Form();
                    popupForm.Controls.Add(addShiftUC);
                    popupForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    popupForm.StartPosition = FormStartPosition.CenterScreen;
                    popupForm.Size = addShiftUC.Size;
                    popupForm.ShowDialog();

                    UpdateUI(date); // Refresh the UI after adding a shift
                };

                Button removeShiftBtn = new Button();
                removeShiftBtn.Text = "-";
                removeShiftBtn.AutoSize = true;
                removeShiftBtn.Click += (sender, e) =>
                {
                    Shift shiftToRemove = (Shift)selectedEmployee.ShiftsDates.FirstOrDefault(s => s.ShiftDate == date);
                    selectedEmployee.ShiftsDates.Remove(shiftToRemove);

                    UpdateUI(date); // Refresh the UI after removing a shift
                };

                buttonsPanel.Controls.Add(addShiftBtn);
                buttonsPanel.Controls.Add(removeShiftBtn);

                containerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                containerPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                containerPanel.Controls.Add(jobPanel, 0, 0);
                containerPanel.Controls.Add(buttonsPanel, 1, 0);

                //containerPanel.ColumnStyles.Clear();
                //containerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // Set the column style to AutoSize

                //containerPanel.RowStyles.Clear();
                //containerPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Set the row style to AutoSize

                //containerPanel.Controls.Add(jobPanel, 0, 0); // Add jobPanel to column 0, row 0
                //containerPanel.SetColumnSpan(jobPanel, 2); // Span the jobPanel across both columns

                //containerPanel.Controls.Add(buttonsPanel, 0, 1); // Add buttonsPanel to column 0, row 1
                //containerPanel.SetColumnSpan(buttonsPanel, 2); // Span the buttonsPanel across both columns

                flowLayoutPanel1.Controls.Add(containerPanel);
            }
        }
    }
}