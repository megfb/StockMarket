using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationRoleClaims
{
    public class ApplicationRoleClaimConfiguration : IEntityTypeConfiguration<ApplicationRoleClaim>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder)
        {
            builder.HasOne(rc => rc.Role).WithMany(r => r.RoleClaims).HasForeignKey(rc => rc.RoleId).IsRequired();

        }
    }
}
