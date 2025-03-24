using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserClaims
{
    public class ApplicationUserClaimRepository(AppDbContext context) : GenericRepository<ApplicationUserClaim>(context), IApplicationUserClaimRepository
    {
    }
}
