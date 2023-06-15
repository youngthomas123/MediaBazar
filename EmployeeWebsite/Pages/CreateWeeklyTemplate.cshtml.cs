using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace EmployeeWebsite.Pages
{
    [Authorize]
    public class CreateWeeklyTemplateModel : PageModel
    {
        private readonly IEmployeeContainer _employeeContainer;
        [BindProperty]
        public ShiftTypes MondayShift { get; set; }

        [BindProperty]
        public ShiftTypes TuesdayShift { get; set; }

        [BindProperty]
        public ShiftTypes WednesdayShift { get; set; }

        [BindProperty]
        public ShiftTypes ThursdayShift { get; set; }

        [BindProperty]
        public ShiftTypes FridayShift { get; set; }

        [BindProperty]
        public ShiftTypes SaturdayShift { get; set; }

        [BindProperty]
        public ShiftTypes SundayShift { get; set; }
        public bool IsEditing { get; set; }
        public Employee Emp { get; set; }
        public Dictionary<DayOfWeek, ShiftTypes>? Preferences { get; set; }
        public CreateWeeklyTemplateModel(IEmployeeContainer employeeContainer)
        {
            _employeeContainer = employeeContainer;
            Preferences= new Dictionary<DayOfWeek, ShiftTypes>();
        }
        public IActionResult OnGet()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var empBsnClaim = claimsIdentity.FindFirst("empBsn");

            if (empBsnClaim == null || !int.TryParse(empBsnClaim.Value, out int bsn))
            {
                return Unauthorized();
            }
            Emp = _employeeContainer.GetEmployeeByBcn(bsn);
            Preferences = Emp.Preferences;

            if (Emp == null)
            {
                return NotFound();
            }

            return Page();
        }
        public IActionResult OnPostSavePreferences()
        {
            IsEditing = false;
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var empBsnClaim = claimsIdentity.FindFirst("empBsn");
            int bsn = int.Parse(empBsnClaim.Value);

            Emp = _employeeContainer.GetEmployeeByBcn(bsn);

            Preferences.Add(DayOfWeek.Monday, MondayShift);
            Preferences.Add(DayOfWeek.Tuesday, TuesdayShift);
            Preferences.Add(DayOfWeek.Wednesday, WednesdayShift);
            Preferences.Add(DayOfWeek.Thursday, ThursdayShift);
            Preferences.Add(DayOfWeek.Friday, FridayShift);
            Preferences.Add(DayOfWeek.Saturday, SaturdayShift);
            Preferences.Add(DayOfWeek.Sunday, SundayShift);

            if (Emp.Preferences.Count == 0)
            {
                _employeeContainer.WriteShiftPreference(bsn, Preferences);
                return RedirectToPage("CreateWeeklyTemplate");
            }


            _employeeContainer.UpdateShiftPreference(int.Parse(empBsnClaim.Value), Preferences);
            return RedirectToPage("CreateWeeklyTemplate");
        }
        public IActionResult OnPostEnableEditing()
        {
            IsEditing = true;
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var empBsnClaim = claimsIdentity.FindFirst("empBsn");
            Emp = _employeeContainer.GetEmployeeByBcn(int.Parse(empBsnClaim.Value));
            Preferences = Emp.Preferences;
            return Page();
        }
    }
}
