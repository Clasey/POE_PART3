using System.Windows;
using POE_PART3.Views;
using POE_PART3.Models;
using POE_PART3.Controllers;

namespace POE_PART3
{
    public class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginView());
        }
    }
}
