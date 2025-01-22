using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application.Contracts.Repositories;


namespace Infrastructure
{
    public static class InfraestructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductoDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("cadena")));
            services.AddScoped<IProductoRepository, ProductoRepository>();
            return services;
        }
    }
}
