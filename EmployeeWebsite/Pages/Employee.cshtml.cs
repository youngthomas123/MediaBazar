
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Globalization;

namespace EmployeeWebsite.Pages
{

    public class EmployeeModel : PageModel
    {
        IEmployeeContainer _employeeContainer;

        public Employee Emp { get; set; }

        public bool IsEditMode { get; set; }
        public List<Employee> Emps { get; set; }

        [BindProperty]
        public SickLeaveViewModel SickLeaveViewModel { get; set; }
        [BindProperty]
        public ShiftPreferenceViewModel ShiftPreferenceViewModel { get; set; }
        [BindProperty]
        public string? ErrorMessage { get; set; }
        [BindProperty]
        public bool SetYearlyPreference { get; set; }

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



        public async Task<IActionResult> OnPostAssignSickLeaveAsync(int bsn)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }

            Emp = _employeeContainer.GetEmployeeByBcn(bsn);

            if (Emp == null)
            {
                return NotFound();
            }

            var startDate = SickLeaveViewModel.StartDate.Date;
            var endDate = SickLeaveViewModel.EndDate.Date;

            if (endDate < startDate)
            {
                ModelState.AddModelError("", "End date must be greater than or equal to start date.");
                return Page();
            }

            if (Emp.SickLeaves == null)
            {
                Emp.SickLeaves = new List<SickLeave>();
            }

            var overlappingSickLeaves = Emp.SickLeaves
                .Where(sl => sl.IsScheduled && ((startDate >= sl.StartDate && startDate <= sl.EndDate) || (endDate >= sl.StartDate && endDate <= sl.EndDate)))
                .ToList();

            if (overlappingSickLeaves.Count > 0)
            {
                ModelState.AddModelError("", "Sick leave overlaps with an existing sick leave.");
                ErrorMessage = "Sick leave overlaps with an existing sick leave.";
                return Page();
            }

            // Create a new SickLeave object from the SickLeaveViewModel
            SickLeave sickLeave = new SickLeave
            {
                StartDate = SickLeaveViewModel.StartDate,
                EndDate = SickLeaveViewModel.EndDate,
                Reason = SickLeaveViewModel.Reason,
                IsScheduled = SickLeaveViewModel.IsScheduled
            };

            Emp.SickLeaves.Add(sickLeave);
            _employeeContainer.UpdateEmpSickLeave(Emp, sickLeave);

            return RedirectToPage("./Employee", new { bsn = Emp.BSN });
        }

        public IActionResult OnPostCreateShiftPreference(int bsn)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }
            Emp = _employeeContainer.GetEmployeeByBcn(bsn);

            if (!SetYearlyPreference)
            {
                ShiftPreference shiftPreference = new ShiftPreference
                {
                    Year = ShiftPreferenceViewModel.Year,
                    Month = (int)ShiftPreferenceViewModel.Month,
                    Preference = ShiftPreferenceViewModel.Preference
                };


                Emp.ShiftPreferences.Add(shiftPreference);
                try
                {
                    _employeeContainer.AddShiftPreference(Emp, shiftPreference);
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message;
                    return Page();

                }

                return RedirectToPage(new { bsn = Emp.BSN });
            }
            else
            {
                foreach (var month in CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Skip(1))
                {
                    int monthIndex = Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, month);
                    ShiftPreference shiftPreference = new ShiftPreference
                    {
                        Year = ShiftPreferenceViewModel.Year,
                        Month = monthIndex,
                        Preference = ShiftPreferenceViewModel.Preference
                    };
                    Emp.ShiftPreferences.Add(shiftPreference);
                    try
                    {
                        _employeeContainer.AddShiftPreference(Emp, shiftPreference);
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage = ex.Message;
                        return Page();
                    }
                }
                return RedirectToPage(new { bsn = Emp.BSN });
            }

        }
    }
}
