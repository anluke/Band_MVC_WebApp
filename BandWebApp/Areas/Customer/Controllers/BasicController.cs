using Microsoft.AspNetCore.Mvc;

namespace BandWebApp.Areas.Customer.Controllers
{
    public class BasicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
