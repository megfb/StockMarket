using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.UsersNotifications.Stockses
{
    public class StocksConfiguration : IEntityTypeConfiguration<Stocks>
    {
        public void Configure(EntityTypeBuilder<Stocks> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Symbol).IsRequired().HasMaxLength(50);
            builder.Property(p => p.CompanyName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Sector).IsRequired().HasMaxLength(50);
            builder.HasMany(p => p.UserStocks).WithOne(p => p.Stocks).HasForeignKey(p => p.SymbolId);
            builder.HasMany(p => p.StockPrices).WithOne(p => p.Stocks).HasForeignKey(p => p.SymbolId);
            builder.HasMany(p => p.StockPricesHistories).WithOne(p => p.Stocks).HasForeignKey(p => p.SymbolId);
            builder.HasMany(p => p.StockTransactions).WithOne(p => p.Stocks).HasForeignKey(p => p.SymbolId);

        }
    }
}
