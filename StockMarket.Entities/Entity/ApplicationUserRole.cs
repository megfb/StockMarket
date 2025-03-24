using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationUserRole : IdentityUserRole<string>, IEntity
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
