
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using S2GroupProject.Classes;
using MediaBazarLib;

namespace EmployeeWebsite.Pages
{
    public class EmployeeModel : PageModel
    {
        public Employee Emp { get; set; }  
        
        public void OnGet(int bsn)
        {
            Emp = Global.myManagement.GetEmployeeByBcn(bsn);
        }

        public void OnPost(bool attendedShift, int bsn)
        {
            Emp = Global.myManagement.GetEmployeeByBcn(bsn);
            attendedShift = true;
            Emp.AttendedShift = attendedShift;
        }
    }
}
