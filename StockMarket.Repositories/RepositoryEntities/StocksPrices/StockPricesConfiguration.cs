using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.StocksPrices
{
    public class StockPricesConfiguration : IEntityTypeConfiguration<StockPrices>
    {
        public void Configure(EntityTypeBuilder<StockPrices> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(x => x.Volume).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
            builder.HasOne(x => x.Stocks).WithMany(x => x.StockPrices).HasForeignKey(x => x.SymbolId);
        }
    }
}
