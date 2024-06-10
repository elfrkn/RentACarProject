using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.DAL
{
    public class RentACar
    {
        public  int RentACarID { get; set; }

        [Column(TypeName ="Date")]
        public  DateTime PckUpDate  { get; set; }

        [Column(TypeName = "Date")]
        public  DateTime DropOffDate { get; set; }
        public  int ReceivingLocationID { get; set; }
        public  ReceivingLocation ReceivingLocation { get; set; }
        public  int DestinationLocationID { get; set; }
        public  DestinationLocation DestinationLocation { get; set; }
        public  int CarID { get; set; }
        public  Car Car { get; set; }

    }
}
