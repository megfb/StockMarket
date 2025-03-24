using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>, IEntity
    {
        public virtual ApplicationRole Role { get; set; }

    }
}
