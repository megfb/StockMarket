using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.StocksPrices
{
    public class StockPricesRepository(AppDbContext context) : GenericRepository<StockPrices>(context), IStockPricesRepository
    {
    }
}
