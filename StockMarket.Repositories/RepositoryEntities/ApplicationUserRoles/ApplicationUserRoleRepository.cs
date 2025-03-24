using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserRoles
{
    public class ApplicationUserRoleRepository(AppDbContext context) : GenericRepository<ApplicationUserRole>(context), IApplicationUserRoleRepository
    {
    }
}
