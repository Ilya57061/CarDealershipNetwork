using Microsoft.EntityFrameworkCore;

namespace CarDealerships.Model.Database
{
    public class CarDealershipContext:DbContext
    {
        public CarDealershipContext(DbContextOptions<CarDealershipContext> options) : base(options)
        {
        }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
