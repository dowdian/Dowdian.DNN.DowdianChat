using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dowdian.Modules.DowdianChat.Hubs
{
    /// <summary>
    /// ChatHub
    /// </summary>
    public class ChatHub : Hub
    {
        /// <summary>
        /// Send
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}