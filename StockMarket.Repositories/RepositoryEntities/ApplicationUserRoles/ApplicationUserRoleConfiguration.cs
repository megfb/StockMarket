using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.ApplicationUserRoles
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoleId });
            builder.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId).IsRequired();
            builder.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId).IsRequired();


        }
    }
}
