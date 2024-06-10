using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Mediator.Results
{
    public class SearchCarQueryResult
    {
        public  int CarID { get; set; }
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public string? BodyType { get; set; }
        public string? MotorPower { get; set; }
        public string? FuelType { get; set; }
        public string? ImageUrl { get; set; }
        public int ReceivingLocationId { get; set; }
        public int DestinationLocationId { get; set; }
       
       

    }
}
