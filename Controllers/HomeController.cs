using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserId") != null)
                return RedirectToAction("Index", "Dashboard");

            return RedirectToAction("Login", "Account");
        }
    }
}