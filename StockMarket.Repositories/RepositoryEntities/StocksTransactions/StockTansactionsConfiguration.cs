using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.StocksTransactions
{
    public class StockTansactionsConfiguration : IEntityTypeConfiguration<StockTransactions>
    {
        public void Configure(EntityTypeBuilder<StockTransactions> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p=>p.TransactionType).IsRequired();
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.TransactionTime).IsRequired();
            builder.HasOne(x => x.ApplicationUser).WithMany(x => x.StockTransactions).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Stocks).WithMany(x => x.StockTransactions).HasForeignKey(x => x.SymbolId);
        }
    }
}
