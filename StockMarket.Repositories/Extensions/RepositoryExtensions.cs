using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockMarket.Repositories.DbContexts;

namespace StockMarket.Repositories.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                var ConnectionString = configuration.GetSection(ConnectionStringOption.Key).Get<ConnectionStringOption>();
                //options.UseSqlServer(ConnectionString!.SqlServer, sqlServerOptionsAction =>
                //{
                //    sqlServerOptionsAction.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.FullName);
                //});
                options.UseNpgsql(ConnectionString!.PostgreSql, postgreSqlServerOptionsAction =>
                {
                    postgreSqlServerOptionsAction.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.FullName);
                });
            });
            return services;
        }
    }
}
