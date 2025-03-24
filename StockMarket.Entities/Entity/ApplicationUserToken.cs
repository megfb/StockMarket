using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationUserToken : IdentityUserToken<string>, IEntity
    {
        public virtual ApplicationUser User { get; set; }

    }
}
