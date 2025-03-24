using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.UsersStocks
{
    public class UserStocksConfiguration : IEntityTypeConfiguration<UserStocks>
    {
        public void Configure(EntityTypeBuilder<UserStocks> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.UserStocks).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Stocks).WithMany(x => x.UserStocks).HasForeignKey(x => x.SymbolId);
        }
    }
}
