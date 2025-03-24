using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationUserClaim : IdentityUserClaim<string>, IEntity
    {
        public virtual ApplicationUser User { get; set; }

    }
}
