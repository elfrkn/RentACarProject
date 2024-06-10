namespace RentACar.DAL
{
    public class DestinationLocation
    {
        public int DestinationLocationID { get; set; }
        public string DestinationLocationName { get; set; }
        public List<RentACar> RentACars { get; set; }
    }
}
