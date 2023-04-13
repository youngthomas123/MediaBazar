using MediaBazar.BusinessLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IEmployeeDataAccess
    {
        void AddEmployee(Employee employee);


        void DeleateEmployee(string BSN);


        List<Employee> LoadEmployees();


        void AddEmpShift(Employee emp);

        void UpdateEmpShift(Employee emp);

        void UpdateEmpSickLeave(Employee emp, SickLeave sickLeave);

        void UpdateEmpSickLeaveApproval(Employee emp, SickLeave sickLeave);

    }
}
