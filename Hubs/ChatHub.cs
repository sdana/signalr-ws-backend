using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PleaseWork.Hubs
{
    public class ChatHub : Hub
    {
        public async Task ChatShit(string message)
        {
           await Clients.Others.SendAsync(message);
        }

        override public async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("works");
        }

        public async Task NewClick()
        {
            await Clients.All.SendAsync("youClicked");
        }

        public async Task NewMessage(string message)
        {
            await Clients.All.SendAsync("downloadMessage", message);
        }
    }
}
