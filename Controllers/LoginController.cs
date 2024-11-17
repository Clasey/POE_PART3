using POE_PART3.Models;

namespace POE_PART3.Controllers
{
    public class LoginController
    {
        private readonly List<User> users = new List<User>
        {
            new User { Username = "lecturer", Password = "password123" },
            new User { Username = "admin", Password = "admin123" }
        };

        public bool Authenticate(string username, string password)
        {
            return users.Any(u => u.Username == username && u.Password == password);
        }
    }
}
