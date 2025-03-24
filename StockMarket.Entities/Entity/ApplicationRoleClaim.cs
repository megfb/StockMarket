using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>, IEntity
    {
        public virtual ApplicationRole Role { get; set; }

    }
}
