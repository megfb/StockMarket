using Microsoft.AspNetCore.SignalR;

namespace StockMarket.Api.Hubs
{
    public class MyHub : Hub<IMyHub>
    {
        public async Task BroadcastMessageToAllClients(string stockSymbol, string message)
        {
            await Clients.All.ReceiveMessageForAllClients(stockSymbol, message);
        }

    }
}
