using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.StockPricesHistories
{
    public class StockPricesHistoryConfiguration : IEntityTypeConfiguration<StockPricesHistory>
    {
        public void Configure(EntityTypeBuilder<StockPricesHistory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(x => x.Volume).IsRequired();
            builder.Property(x => x.TimeStamp).IsRequired();
            builder.HasOne(x => x.Stocks).WithMany(x => x.StockPricesHistories).HasForeignKey(x => x.SymbolId);
        }
    }
}
