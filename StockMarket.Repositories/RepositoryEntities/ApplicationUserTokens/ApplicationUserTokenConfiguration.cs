using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserTokens
{
    public class ApplicationUserTokenConfiguration : IEntityTypeConfiguration<ApplicationUserToken>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
        {
            builder.HasKey(x => new { x.UserId, x.LoginProvider, x.Name });
            builder.HasOne(ut => ut.User).WithMany(u => u.Tokens).HasForeignKey(ut => ut.UserId).IsRequired();
        }
    }
}
