using Microsoft.AspNetCore.Mvc;
using WebApp.dbContext;
using WebApp.Models;

namespace WebApp.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}