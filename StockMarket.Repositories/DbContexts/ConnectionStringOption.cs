namespace StockMarket.Repositories.DbContexts
{
    public class ConnectionStringOption
    {
        public const string Key = "ConnectionStrings";
        public string PostgreSql { get; set; } = default!;
        public string SqlServer { get; set; } = default!;
    }
}
