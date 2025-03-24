using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.Stockses
{
    public class StocksRepository(AppDbContext context) : GenericRepository<Stocks>(context), IStocksRepository
    {
    }
}
