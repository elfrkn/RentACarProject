using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Mediator.Results
{
    public class SearchCarQueryResult
    {
        public int RentACarID { get; set; }
        public int CarBrand { get; set; }
        public int CarModel { get; set; }
        public string? BodyType { get; set; }
        public string? MotorPower { get; set; }
        public string? FuelType { get; set; }
        public string ImageUrl { get; set; }
        public string MyProperty { get; set; }
        public string ReceivingLocation { get; set; }
        public string DestinationLocation { get; set; }

        [Column(TypeName = "Date")]
        public DateTime PckUpDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DropOffDate { get; set; }

        public int LacationID { get; set; }
   
    }
}
