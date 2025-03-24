using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class StockTransactions:IEntity
    {
        public int Id { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public string UserId { get; set; }
        public Stocks? Stocks { get; set; }
        public int SymbolId { get; set; }
        public string TransactionType { get; set; } = default!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime TransactionTime { get; set; }
    }
}
