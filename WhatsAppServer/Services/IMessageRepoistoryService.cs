using EdenWhatsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace WhatsAppServer.Services
{
    public interface IMessageRepoistoryService
    {
        Subject<MessageModel> MessageObservable { get; }
        void InsertMessage(MessageModel message);
        int GetNewUserId();
    }
}
