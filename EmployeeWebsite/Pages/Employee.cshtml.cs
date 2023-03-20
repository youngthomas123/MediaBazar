
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using S2GroupProject.Classes;
using MediaBazarLib;
using MediaBazarLib.Classes;

namespace EmployeeWebsite.Pages
{
    public class EmployeeModel : PageModel
    {
        public Employee Emp { get; set; }  
        
        public void OnGet(int bsn)
        {
            Emp = Global.myManagement.GetEmployeeByBcn(bsn);
        }

        public void OnPost(int bsn, int shiftAtIndex)
        {
            Emp = Global.myManagement.GetEmployeeByBcn(bsn);
            Emp.ShiftsDates[shiftAtIndex].AttendedShift = true;
            DataBaseManager database = new DataBaseManager();
            database.UpdateEmpShift(Emp);
        }
    }
}
