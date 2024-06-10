namespace RentACar.DAL
{
    public class ReceivingLocation
    {
        public  int ReceivingLocationID { get; set; }
        public  string LocationName { get; set; }
        public  List<RentACar> RentACars { get; set; }
    }
}
