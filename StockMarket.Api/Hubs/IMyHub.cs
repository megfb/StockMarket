namespace StockMarket.Api.Hubs
{
    public interface IMyHub
    {
        Task ReceiveMessageForAllClients(string stockSymbol,string message);
    }
}
