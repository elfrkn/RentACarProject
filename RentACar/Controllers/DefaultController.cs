using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.CQRS.Handlers;
using RentACar.CQRS.Queries;
using RentACar.DAL;
using RentACar.Mediator.Queries;
using RentACar.Models;
using System.Data;

namespace RentACar.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly Context _context;
        private readonly IMediator _mediator;


        public DefaultController(GetCarQueryHandler getCarQueryHandler, Context context, IMediator mediator)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _context = context;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            List<SelectListItem> values = (from x in _context.ReceivingLocations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.LocationName,
                                               Value = x.ReceivingLocationID.ToString()
                                           }).ToList();
            ViewBag.ReceivingLocation = values;

            List<SelectListItem> values2 = (from x in _context.DestinationLocations.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.DestinationLocationName,
                                                Value = x.DestinationLocationID.ToString()
                                            }).ToList();
            ViewBag.DestinationLocation = values2;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchCar(SearchCarViewModel model)
        {
            var result = await _mediator.Send(new SearchCarQuery(model.DestinationLocationID, model.ReceivingLocationID, model.DropOffDate, model.PickUpDate));
            return View(result);
        }
        public IActionResult CarList()
        {
            var values = _getCarQueryHandler.Handle();
            return View(values);
        }


   
    }
}
