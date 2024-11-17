using System.Security.Principal;
using System.Windows;
using POE_PART3.Controllers;
using POE_PART3.Models;


namespace POE_PART3.Views
{
    public partial class LoginView : Window
    {
        private readonly LoginController loginController = new LoginController();

        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (loginController.Authenticate(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                var claimView = new ClaimView();
                claimView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
