using Microsoft.AspNetCore.Mvc;
using POE_PART3.Models;

namespace POE_PART3.Controllers
{
    public class ClaimController : Controller
    {
        private static List<Claim> claims = new List<Claim>
        {
            new Claim { Id = 1, Description = "January Claim", Amount = 1000, DateSubmitted = DateTime.Now.AddMonths(-1) },
            new Claim { Id = 2, Description = "February Claim", Amount = 1200, DateSubmitted = DateTime.Now.AddMonths(-2) }
        };

        public IActionResult Index()
        {
            return View(claims);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Claim claim)
        {
            if (ModelState.IsValid)
            {
                claim.Id = claims.Count + 1;
                claim.DateSubmitted = DateTime.Now;
                claims.Add(claim);
                return RedirectToAction("Index");
            }
            return View(claim);
        }
    }
}
