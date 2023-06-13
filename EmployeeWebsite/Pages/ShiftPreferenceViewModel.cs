using MediaBazar.BusinessLogic.Classes;

namespace EmployeeWebsite.Pages
{
    public class ShiftPreferenceViewModel
    {
        public int Year { get; set; }
        public int? Month { get; set; }
        public MyEnums.ShiftTypes Preference { get; set; }
    }
}
