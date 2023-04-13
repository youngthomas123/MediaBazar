
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;




namespace EmployeeWebsite.Pages
{
   
    public class EmployeeModel : PageModel
    {
        IEmployeeContainer _employeeContainer;

        public Employee Emp { get; set; }

        public bool IsEditMode { get; set; }
        public List<Employee> Emps { get; set; }

        [BindProperty]
        public SickLeave SickLeave { get; set; }    
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

            var startDate = SickLeave.StartDate.Date;
            var endDate = SickLeave.EndDate.Date;

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
                return Page();
            }

           
            Emp.SickLeaves.Add(SickLeave);

             _employeeContainer.UpdateEmpSickLeave(Emp, SickLeave);

            return RedirectToPage("./Employee", new { bsn = Emp.BSN });
        }
    }
}
