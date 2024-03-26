using Castle.Core.Configuration;
using Garaj.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace Garaj.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastruct(this IServiceCollection services)
        {
            services.AddDbContext<GarajDbContext>(ops =>
                ops
                    .UseLazyLoadingProxies()
                        .UseNpgsql(connectionString: "Host=localhost;Port=5432;Database=Car.BLZ;User Id=postgres;Password=root"));


            return services;
        }
    }
}
