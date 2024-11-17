using Microsoft.AspNetCore.Mvc;
using POE_PART3.Models;

namespace POE_PART3.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: User/Login
        [HttpPost]
        public ActionResult Login(User user)
        {
            // Here, you would check the credentials against a database or in-memory store
            if (user.Username == "admin" && user.Password == "password123")
            {
                // Login successful, redirect to a secure area
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Login failed, show an error message
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }
    }
}
