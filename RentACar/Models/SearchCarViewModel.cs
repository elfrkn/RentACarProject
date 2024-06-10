namespace RentACar.Models
{
    public class SearchCarViewModel
    {
        public  int ReceivingLocationID { get; set; }
        public  int DestinationLocationID { get; set; }
        public  DateTime PickUpDate { get; set; }
        public  DateTime DropOffDate { get; set; }
    }
}
