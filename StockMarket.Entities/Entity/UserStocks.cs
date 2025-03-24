using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class UserStocks:IEntity
    {
        public int Id { get; set; }
        public ApplicationUser? User { get; set; }
        public string UserId { get; set; }
        public Stocks? Stocks { get; set; }
        public int SymbolId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
