using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.StockPricesHistories
{
    public class StockPricesHistoryRepository(AppDbContext context) : GenericRepository<StockPricesHistory>(context), IStockPricesHistoryRepository
    {
    }
}
