using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class Stocks : IEntity
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = default!;
        public string CompanyName { get; set; } = default!;
        public string Sector { get; set; } = default!;
        public ICollection<UserStocks>? UserStocks { get; set; }
        public ICollection<StockPrices>? StockPrices { get; set; }
        public ICollection<StockPricesHistory>? StockPricesHistories { get; set; }
        public ICollection<StockTransactions>? StockTransactions { get; set; }

    }
}
