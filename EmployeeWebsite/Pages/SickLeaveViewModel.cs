namespace EmployeeWebsite.Pages
{
    public class SickLeaveViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Reason { get; set; }
        public bool IsScheduled { get; set; }
    }
}
