using Microsoft.EntityFrameworkCore;

namespace AplikasiBarbershop.DataModel
{
    public class BarberDbContext: DbContext
    {
        public BarberDbContext(DbContextOptions<BarberDbContext> options): base(options)
        {
        }
        public DbSet<MasterServicesTable> MasterServices { get; set; }
        public DbSet<MasterTeamTable> MasterTeams { get; set; }
        public DbSet<MasterCustomerTable> MasterCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MasterServicesConfig());
            modelBuilder.ApplyConfiguration(new MasterTeamConfig());
            modelBuilder.ApplyConfiguration(new MasterCustomerConfig());
        }
    }
}
