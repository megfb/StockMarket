using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class StockPricesHistory:IEntity
    {
        public int Id { get; set; }
        public Stocks? Stocks { get; set; }
        public int SymbolId { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
