using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserClaims
{
    public class ApplicationUserClaimConfiguration : IEntityTypeConfiguration<ApplicationUserClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserClaim> builder)
        {
            builder.HasOne(uc => uc.User).WithMany(u => u.Claims).HasForeignKey(uc => uc.UserId).IsRequired();
        }
    }
}
