using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.CQRS.Handlers;
using RentACar.CQRS.Queries;
using RentACar.DAL;
using System.Data;

namespace RentACar.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly Context _context;


        public DefaultController(GetCarQueryHandler getCarQueryHandler, Context context)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _context = context;
        }

        public IActionResult Index()
        {
            List<SelectListItem> values = (from x in _context.Locations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.LocationName,
                                               Value = x.LocationID.ToString()
                                           }).ToList();
            ViewBag.ReceivingLocation = values;

            List<SelectListItem> values2 = (from x in _context.Locations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.LocationName,
                                               Value = x.LocationID.ToString()
                                           }).ToList();
            ViewBag.DestinationLocation = values;
            return View();
        }

        public IActionResult CarList()
        {
            var values = _getCarQueryHandler.Handle();
            return View(values);
        }
   
    }
}
