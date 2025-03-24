using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUsers
{
    public class ApplicationUserRepository(AppDbContext context) : GenericRepository<ApplicationUser>(context), IApplicationUserRepository
    {
    }
}
