using RentACar.CQRS.Results;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers
{
    public class GetCarQueryHandler
    {
        private readonly Context _context;

        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarQueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetCarQueryResult
            {
                CarID = x.CarID,
                CarBrand = x.CarBrand,
                CarModel = x.CarModel,
                CarKM = x.CarKM,
                FuelType = x.FuelType,
                MotorPower = x.MotorPower,
                ImageUrl = x.ImageUrl,
                Price = x.Price
            }).ToList();
            return values;
        }
    }
}
