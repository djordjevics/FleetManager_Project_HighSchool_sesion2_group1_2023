using Microsoft.EntityFrameworkCore;

namespace DataRepo.Models
{
    public class FleetDbContext : DbContext
    {
        public DbSet<FuelLogData> fuelLogData { get; set;}

        public DbSet<VehicleData> vehicleData { get; set;}

        public FleetDbContext(DbContextOptions<FleetDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
