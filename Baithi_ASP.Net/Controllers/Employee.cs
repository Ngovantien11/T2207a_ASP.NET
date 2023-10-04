using Microsoft.AspNetCore.Mvc;

namespace Baithi_ASP.Net.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
