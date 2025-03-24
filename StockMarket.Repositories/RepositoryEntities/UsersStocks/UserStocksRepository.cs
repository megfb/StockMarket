using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.UsersStocks
{
    public class UserStocksRepository(AppDbContext context) : GenericRepository<UserStocks>(context), IUserStocksRepository
    {
    }
}
