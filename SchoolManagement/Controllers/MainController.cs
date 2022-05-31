using Microsoft.AspNetCore.Mvc;

namespace SchoolManagement.Models
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
