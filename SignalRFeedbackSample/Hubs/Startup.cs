using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(SignalRFeedbackSample.Startup))]
namespace SignalRFeedbackSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}