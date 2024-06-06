using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarList()
        {
            return View();
        }
    }
}
