using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Asp.Net_Core_SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            await Clients.Group("1").SendAsync("ReceiveMessage", "System", "This is only for group 1");
            await Clients.Group("2").SendAsync("ReceiveMessage", "System", "This is only for group 2");
        }
        public override async Task OnConnectedAsync()
        {
            var group = Context.GetHttpContext().Request.Query["token"];

            string value = !string.IsNullOrEmpty(group.ToString()) ? group.ToString() : "default";

            await Groups.AddToGroupAsync(Context.ConnectionId, value);
            await base.OnConnectedAsync();
        }
    }
}
