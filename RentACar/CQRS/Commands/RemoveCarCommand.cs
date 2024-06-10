namespace RentACar.CQRS.Commands
{
    public class RemoveCarCommand
    {
        public RemoveCarCommand(int carId)
        {
            CarId = carId;
        }

        public  int CarId { get; set; }
    }
}
