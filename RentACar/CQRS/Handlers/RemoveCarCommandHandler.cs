using RentACar.CQRS.Commands;
using RentACar.DAL;

namespace RentACar.CQRS.Handlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveCarCommand command)
        {
            var value = _context.Cars.Find(command.CarId);
            _context.Cars.Remove(value);
            _context.SaveChanges();
        }
    }
}
