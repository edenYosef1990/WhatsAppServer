using EdenWhatsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace WhatsAppServer.Services
{
    public class MessageRepositoryService : IMessageRepoistoryService
    {
        private int newestId = 0;

        public Subject<MessageModel> MessageObservable { get; }

        public int GetNewUserId()
        {
            return newestId++;
        }

        public MessageRepositoryService()
        {
            MessagesList = new List<MessageModel>();
            MessageObservable = new Subject<MessageModel>();
        }


        public void InsertMessage(MessageModel message)
        {
            MessageObservable.OnNext(message);
            MessagesList.Add(message);
        }

        public List<MessageModel> MessagesList { get; set; }
    }
}
