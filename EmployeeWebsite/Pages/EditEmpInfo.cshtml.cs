using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeWebsite.Pages
{
    public class EditEmpInfoModel : PageModel
    {
        IEmployeeContainer _employeeContainer;
        public Employee Emp { get; set; }
        [BindProperty]
        public string? FirstName { get; set; }
        [BindProperty]
        public string? LastName { get; set; }
        [BindProperty]
        public string? Address { get; set; }
        [BindProperty]
        public string? TelNumber { get; set; }

        public void OnGet(int bsn)
        {
            Emp = _employeeContainer.GetEmployeeByBcn(bsn);
        }

        public EditEmpInfoModel(IEmployeeContainer employeeContainer)
        {
            _employeeContainer = employeeContainer;
        }

        public IActionResult OnPost(int bsn)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }

            Emp = _employeeContainer.GetEmployeeByBcn(bsn);

            if (!string.IsNullOrEmpty(FirstName))
            {
                Emp.FirstName = FirstName;
                _employeeContainer.UpdateEmployeeFirstName(Emp, FirstName);
            }

            if (!string.IsNullOrEmpty(LastName))
            {
                Emp.LastName = LastName;
                _employeeContainer.UpdateEmployeeLastName(Emp, LastName);
            }

            if (!string.IsNullOrEmpty(Address))
            {
                Emp.Address = Address;
                _employeeContainer.UpdateEmployeeAddress(Emp, Address);
            }

            if (!string.IsNullOrEmpty(TelNumber))
            {
                Emp.TelNumber = TelNumber;
                _employeeContainer.UpdateEmployeeTelNumber(Emp, TelNumber);
            }

            return RedirectToPage("Employee", new { bsn = Emp.BSN });
        }
    }
}
