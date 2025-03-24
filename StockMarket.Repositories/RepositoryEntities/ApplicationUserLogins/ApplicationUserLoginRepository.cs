using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserLogins
{
    public class ApplicationUserLoginRepository(AppDbContext context) : GenericRepository<ApplicationUserLogin>(context), IApplicationUserLoginRepository
    {
    }
}
