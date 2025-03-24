using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.StocksTransactions
{
    public class StockTransactionsRepository(AppDbContext context) : GenericRepository<StockTransactions>(context), IStockTransactionsRepository
    {
    }
}
