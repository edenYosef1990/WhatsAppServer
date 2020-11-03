using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdenWhatsApp.DataStorage;
using EdenWhatsApp.Hubs;
using EdenWhatsApp.TimerFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace EdenWhatsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _hub;
        private TimerManager _timerManager;

        public ChatController(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            _timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferChatData", DataManager.GetData()));

            return Ok(new { Message = "Request Completed" });
        }
    }
}
