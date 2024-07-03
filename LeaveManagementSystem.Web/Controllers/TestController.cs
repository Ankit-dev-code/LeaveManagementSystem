using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Master",
                DateOfBirth = new DateTime(2000,07,21)
            };
            return View(data);
        }
    }
}
