using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class UserNotifications:IEntity
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
