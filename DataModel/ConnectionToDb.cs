using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AplikasiBarbershop.DataModel
{
    public static class ConnectionToDb
    {
        public static ConfigurationManager Configuration;
        public static void AddDomainContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            Configuration = configuration;
            services.AddDbContext<BarberDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DB_Conn"));
            });
        }
    }
}
