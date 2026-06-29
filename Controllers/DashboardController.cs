using EmployeeManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Check if user is logged in
            if (HttpContext.Session.GetString("UserId") == null)
                return RedirectToAction("Login", "Account");

            ViewBag.TotalEmployees = _context.Employees.Count();
            ViewBag.TotalDepartments = _context.Departments.Count();
            ViewBag.Username = HttpContext.Session.GetString("Username");

            return View();
        }
    }
}