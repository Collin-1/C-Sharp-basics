using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleCRUDMVC.Data;
using SampleCRUDMVC.Models;
using System.Threading.Tasks;

namespace SampleCRUDMVC.Controllers
{
    [Authorize] // Made sure only logged in users can access their own profile
    public class EmployeeProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeProfileController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /EmployeeProfile/Index
        public async Task<IActionResult> Index()
        {
            // Get the current user's email only when the Identity user's email matches the Employee.EmailAddress.
            var userEmail = User.Identity?.Name;
            if (string.IsNullOrEmpty(userEmail))
            {
                return RedirectToAction("Index", "Home");
            }

            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.EmailAddress == userEmail);
            if (employee == null)
            {
                return NotFound("Your employee profile was not found. Contact admin.");
            }
            return View(employee);
        }
    }
}
