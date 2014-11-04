using Microsoft.AspNet.SignalR;

namespace SignalRFeedbackSample
{
    public class FeedbackHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addNewMessageToPage(message);
        }
    }
}