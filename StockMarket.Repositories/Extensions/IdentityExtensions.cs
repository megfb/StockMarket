using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;

namespace StockMarket.Repositories.Extensions
{
    public static class IdentityExtensions
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            return services;
        }
    }
}
