
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.Data.SqlClient;
using System.Reflection;

namespace EmployeeWebsite.Pages
{
	public class IndexModel : PageModel
	{
        public List<Employee> Employees { get; set; }
        IEmployeeContainer _employeeContainer;
        public Employee Employee { get; set; }
        private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger, IEmployeeContainer employeeContainer)
        {
			_logger = logger;
            _employeeContainer = employeeContainer;
            Employees = _employeeContainer.LoadEmployees();
		}

		public void OnGet()
		{
            //DataBaseManager database = new DataBaseManager();
            
		}
     
        public IActionResult OnPost(string username, int bsn)
        {
            if (CheckLogin(username, bsn))
            {
                return RedirectToPage("/Employee", new { bsn });
            }
            else
            {
                ViewData["ErrorMessage"] = "Invalid username or password.";
                return Page();
            }
            // Perform any necessary logic here

        }
























        public bool CheckLogin(string username, int password)
        {
            // Replace the following code with your own logic for checking username and password
            foreach (var emp in Employees)
            {
                if (username == emp.FirstName + " " + emp.LastName && password == emp.BSN)
                {
                    return true;
                }
                //else
                //{
                //    return false;
                //}
            }
            return false;
        }
        //public IActionResult OnPost(string username, int bsn) 
        //{
        //    if (CheckLogin(username, bsn))
        //    {
        //        return RedirectToPage("/Employee");
        //    }
        //    else 
        //    {
        //        ViewData["ErrorMessage"] = "Invalid username or password.";
        //        return Page();
        //    }       
        //}
        //public IActionResult OnPost(string username, int password)
        //{
        //    if (CheckLogin(username, password))
        //    {
        //        // Redirect to the main page if login succeeds
        //        return RedirectToPage("/Employee");
        //    }
        //    else
        //    {
        //        // Show an error message if login fails
        //        TempData["ErrorMessage"] = "Invalid username or password.";
        //        return Page();
        //    }
        //}
    }

   
}