
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;




namespace EmployeeWebsite.Pages
{
    public class EmployeeModel : PageModel
    {
        IEmployeeContainer _employeeContainer;

        public Employee Emp { get; set; }


        public EmployeeModel(IEmployeeContainer employeeContainer) 
        {
            _employeeContainer = employeeContainer;
        }  
         
        
        public void OnGet(int bsn)
        {
            Emp = _employeeContainer.GetEmployeeByBcn(bsn);
        }

        public void OnPost(int bsn, int shiftAtIndex)
        {
            Emp = _employeeContainer.GetEmployeeByBcn(bsn);
            Emp.ShiftsDates[shiftAtIndex].AttendedShift = true;
            
            _employeeContainer.UpdateEmpShift(Emp);
        }
    }
}
