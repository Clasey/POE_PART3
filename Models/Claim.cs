namespace POE_PART3.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; } // "Pending", "Approved", "Rejected"
        public string DocumentPath { get; set; } // For file upload
        public DateTime DateSubmitted { get; set; } // Date of submission
    }
}
