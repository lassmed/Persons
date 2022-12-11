using Microsoft.AspNetCore.Mvc;

namespace TP_3.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
