﻿using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationUser : IdentityUser, IEntity
    {
        public string FullName { get; set; } = default!;
        public ICollection<UserStocks>? UserStocks { get; set; }
        public ICollection<UserNotifications>? UserNotifications { get; set; }
        public ICollection<StockTransactions>? StockTransactions { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
    }
}