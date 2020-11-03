using EdenWhatsApp.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdenWhatsApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task BroadcastChatData(List<MessageModel> data)
        {
            await Clients.All.SendAsync("broadcastChatData", data);
        }
    }

}
