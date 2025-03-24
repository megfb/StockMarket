using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockMarket.Entities.Entity;

namespace StockMarket.Repositories.RepositoryEntities.UsersNotifications
{
    public class UserNotificationsConfiguration : IEntityTypeConfiguration<UserNotifications>
    {
        public void Configure(EntityTypeBuilder<UserNotifications> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Message).HasMaxLength(250).IsRequired();
            builder.Property(p => p.CreatedAt).IsRequired();
        }
    }
}
