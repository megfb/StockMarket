using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Entity
{
    public class UserNotifications : IEntity
    {
        public int Id { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; } = default!;
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
