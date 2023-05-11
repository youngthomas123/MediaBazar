using MediaBazar.BusinessLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IEmployeeContainer
    {
        void AddEmployee(Employee employee);


        void DeleateEmployee(int BSN);


        List<Employee> LoadEmployees();


        void AddEmpShift(Employee emp);

        void UpdateEmpShift(Employee emp);

        void UpdateEmpSickLeave(Employee emp, SickLeave sickLeave);

        void UpdateEmpSickLeaveApproval(Employee emp, SickLeave sickLeave);

        // management 

        void AddEmployee(string firstName, string lastName, int bsn, string telNumber, string address,
                        ContractTypes contractType, int hoursPerWeek, JobPositions jobposition, double wage,
                        List<DayOfWeek> daysOff, int age, List<Shift> shiftDates, List<SickLeave> sickLeaves);


        Employee GetEmployeeByBcn(int bsn);

        List<Employee> GetEmployees();

        bool AlreadyExists(int bsn);

        void AddShift(DateTime day, int bsn, ShiftTypes shiftType);
    }
}
