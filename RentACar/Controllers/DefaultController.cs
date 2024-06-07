using Microsoft.AspNetCore.Mvc;
using RentACar.CQRS.Handlers;
using System.Data;

namespace RentACar.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;

        public DefaultController(GetCarQueryHandler getCarQueryHandler)
        {
            _getCarQueryHandler = getCarQueryHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarList()
        {
            var values = _getCarQueryHandler.Handle();
            return View(values);
        }
    }
}
