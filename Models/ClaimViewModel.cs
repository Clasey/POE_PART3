namespace POE_PART3.Models
{
    public class ClaimViewModel
    {
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Notes { get; set; }
        public IFormFile SupportingDocument { get; set; }
    }
}
