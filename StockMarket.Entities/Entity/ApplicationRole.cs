using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationRole : IdentityRole, IEntity
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
