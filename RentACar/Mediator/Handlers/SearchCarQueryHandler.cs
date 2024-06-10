using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RentACar.DAL;
using RentACar.Mediator.Queries;
using RentACar.Mediator.Results;

namespace RentACar.Mediator.Handlers
{
    public class SearchCarQueryHandler : IRequestHandler<SearchCarQuery,List<SearchCarQueryResult>>
    {
        private readonly Context _context;
        public SearchCarQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<SearchCarQueryResult>> Handle(SearchCarQuery request, CancellationToken cancellationToken)
        {
            var values = await  _context.RentACars.Include(x => x.Car).Include(x => x.DestinationLocation).Include(x => x.DestinationLocation).Where(x => x.DestinationLocationID == request.DestinationLocationId || x.ReceivingLocationID == request.ReceivingLocationId || x.PckUpDate == request.PckUpDate || x.DropOffDate == request.DropOffDate).ToListAsync();
              return values.Select(x=> new SearchCarQueryResult
            {
                CarID =x.CarID,
                CarBrand=x.Car.CarBrand,
                CarModel =x.Car.CarModel,
                BodyType=x.Car.BodyType,
                FuelType=x.Car.FuelType,
                ImageUrl=x.Car.ImageUrl,
                MotorPower=x.Car.MotorPower,
                DestinationLocationId=x.DestinationLocationID,
                ReceivingLocationId=x.ReceivingLocationID,
            }).ToList();
        }
    }
}
