using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace MediaBazar.BusinessLogic.Containers
{
    public class EmployeeContainer : IEmployeeContainer
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;

        List<Employee> employees  = new List<Employee>();   

        public EmployeeContainer(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeDataAccess.AddEmployee(employee);
        }

        public void AddEmployee(string firstName, string lastName, int bsn, string telNumber, string address,
                                MyEnums.ContractTypes contractType, int hoursPerWeek, MyEnums.JobPositions jobposition, 
                                double wage, List<DayOfWeek> daysOff, int age, List<Shift> shiftDates, List<SickLeave> sickLeaves, List<ShiftPreference> shiftPreferences)
        {
            
            shiftDates = new List<Shift>();
            sickLeaves = new List<SickLeave>();
            shiftPreferences= new List<ShiftPreference>();
            bool EmployeeExists = AlreadyExists(bsn);
            if (EmployeeExists == false)
            {
                Employee newEmployee = new Employee(firstName, lastName, bsn, telNumber, address, contractType, hoursPerWeek, jobposition,
                                        wage, daysOff, age, shiftDates, sickLeaves, shiftPreferences);
                employees.Add(newEmployee);
                _employeeDataAccess.AddEmployee(newEmployee);
            }
        }

        public void AddEmpShift(Employee emp)
        {
            _employeeDataAccess.AddEmpShift(emp);
        }

        public void AddShift(DateTime day, int bsn, MyEnums.ShiftTypes shiftType)
        {
            Shift shift = new Shift(day, shiftType, false);
            Employee emp = GetEmployeeByBcn(bsn);

            emp.ShiftsDates.Add(shift);
            _employeeDataAccess.AddEmpShift(emp);
        }
        public void RemoveEmpShift(Employee emp, DateTime date)
        {
            _employeeDataAccess.RemoveEmpShift(emp, date);
        }

        public void DeleateEmployee(int BSN)
        {
            _employeeDataAccess.DeleateEmployee(BSN);
        }

        public Employee GetEmployeeByBcn(int bsn)
        {
            
            employees = _employeeDataAccess.LoadEmployees();

            foreach (Employee employee in employees)
            {
                if (employee.BSN == bsn)
                {
                    return employee;
                }
            }
            throw new Exception("Employee not found");
        }
        public List<Employee> GetEmployeesByJobPosition(JobPositions job)
        {

            employees = _employeeDataAccess.LoadEmployees();
            List<Employee> employeeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Jobposition == job)
                {
                    employeeList.Add(employee);
                }
            }
            return employeeList;
        }

        public List<Employee> GetEmployees()
        {
             employees = _employeeDataAccess.LoadEmployees();
          
            return employees;
        }

        public List<Employee> LoadEmployees()
        {
            List <Employee> employees = _employeeDataAccess.LoadEmployees();

            return employees;   
        }

       

        public void UpdateEmpShift(Employee emp)
        {
            _employeeDataAccess.UpdateEmpShift(emp);
        }

        public bool AlreadyExists(int bsn)
        {
            bool employeeFound = false;
            foreach (Employee employee in employees)
            {
                if (employee.BSN == bsn)
                {

                    employeeFound = true;
                    break;
                }
            }
            return employeeFound;
        }

        public void UpdateEmpSickLeave(Employee emp, SickLeave sickLeave)
        {
            _employeeDataAccess.UpdateEmpSickLeave(emp, sickLeave);
        }

        public void UpdateEmpSickLeaveApproval(Employee emp, SickLeave sickLeave)
        {
            _employeeDataAccess.UpdateEmpSickLeaveApproval(emp, sickLeave);
        }

        public void AddShiftPreference(Employee emp, ShiftPreference preference)
        {
            _employeeDataAccess.AddShiftPreference(emp, preference);
        }

        public void UpdateEmployeeFirstName(Employee emp, string newFirstName)
        {
            _employeeDataAccess.UpdateEmployeeFirstName(emp, newFirstName);
        }

        public void UpdateEmployeeLastName(Employee emp, string newLastName)
        {
            _employeeDataAccess.UpdateEmployeeLastName(emp, newLastName);
        }

        public void UpdateEmployeeTelNumber(Employee emp, string newTelNumber)
        {
            _employeeDataAccess.UpdateEmployeeTelNumber(emp, newTelNumber);
        }

        public void UpdateEmployeeAddress(Employee emp, string newAddress)
        {
            _employeeDataAccess.UpdateEmployeeAddress(emp, newAddress);
        }

        public void UpdateEmployeSickLeaveManagerMessage(SickLeave sickLeave, Employee emp)
        {
            _employeeDataAccess.UpdateEmployeSickLeaveManagerMessage(sickLeave, emp);
        }
    }
}
