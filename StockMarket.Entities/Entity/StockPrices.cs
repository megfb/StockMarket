using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class StockPrices : IEntity
    {
        public int Id { get; set; }
        public Stocks? Stocks { get; set; }
        public int SymbolId { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
