using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(Dowdian.Modules.DowdianChat.Startup))]
namespace Dowdian.Modules.DowdianChat
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}