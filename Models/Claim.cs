namespace POE_PART3.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string LecturerName { get; set; }
        public DateTime DateSubmitted { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public double TotalAmount => HoursWorked * HourlyRate;
        public string Status { get; set; } = "Pending";

    }
}
