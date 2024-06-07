using Microsoft.EntityFrameworkCore;

namespace RentACar.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI; initial Catalog=RentACar; integrated security=true");
        }

        public  DbSet<Car> Cars { get; set; }
        public  DbSet<RentACar> RentACars { get; set; }
    }
}
