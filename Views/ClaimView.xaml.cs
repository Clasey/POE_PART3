using System.Windows;
using POE_PART3.Controllers;
using POE_PART3.Views;

namespace POE_PART3.Views
{
    public partial class ClaimView : Window
    {
        private readonly ClaimController claimController = new ClaimController();

        public ClaimView()
        {
            InitializeComponent();
            RefreshClaims();
        }

        private void RefreshClaims()
        {
            ClaimsListView.ItemsSource = null;
            ClaimsListView.ItemsSource = claimController.GetClaims();
        }

        private void AddClaim_Click(object sender, RoutedEventArgs e)
        {
            var newClaim = new Claim
            {
                ClaimId = claimController.GetClaims().Count + 1,
                LecturerName = "John Doe",
                HoursWorked = 40,
                HourlyRate = 50,
                DateSubmitted = DateTime.Now
            };

            claimController.AddClaim(newClaim);
            RefreshClaims();
        }
    }
}
