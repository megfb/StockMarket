using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationRoleClaims
{
    public class ApplicationRoleClaimRepository(AppDbContext context) : GenericRepository<ApplicationRoleClaim>(context), IApplicationRoleClaimRepository
    {
    }
}
