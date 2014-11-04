using Microsoft.AspNet.SignalR;
using System.Threading;
using System.Web.Http;

namespace SignalRFeedbackSample.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public string Get(string connectionId)
        {
            //Connect to the SignalR feedback hub
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<FeedbackHub>();

            //Send a feedback message to the specific client
            hubContext.Clients.Client(connectionId).addNewMessageToPage("Starting the API process...");
            //Wait before the next operation
            Thread.Sleep(2000);

            hubContext.Clients.Client(connectionId).addNewMessageToPage("Reading the database 1...");
            Thread.Sleep(2000);

            hubContext.Clients.Client(connectionId).addNewMessageToPage("Reading the database 2...");
            Thread.Sleep(2000);

            hubContext.Clients.Client(connectionId).addNewMessageToPage("Reading the database 3...");
            Thread.Sleep(2000);

            hubContext.Clients.Client(connectionId).addNewMessageToPage("Reading the database 4...");
            Thread.Sleep(2000);

            hubContext.Clients.Client(connectionId).addNewMessageToPage("Updating the database...");
            Thread.Sleep(2000);

            hubContext.Clients.Client(connectionId).addNewMessageToPage("Processing Complete...");
            return "API Call Complete";
        }
    }
}
