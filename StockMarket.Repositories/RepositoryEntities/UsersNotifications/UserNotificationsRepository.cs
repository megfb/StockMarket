using StockMarket.Entities.Entity;
using StockMarket.Repositories.DbContexts;
using StockMarket.Repositories.GenericRepositoryBase;

namespace StockMarket.Repositories.RepositoryEntities.UsersNotifications
{
    public class UserNotificationsRepository(AppDbContext context) : GenericRepository<UserNotifications>(context), IUserNotificationsRepository
    {
    }
}
