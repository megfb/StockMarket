using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserTokens
{
    public class ApplicationUserTokenRepository(AppDbContext context) : GenericRepository<ApplicationUserToken>(context), IApplicationUserTokenRepository
    {
    }
}
