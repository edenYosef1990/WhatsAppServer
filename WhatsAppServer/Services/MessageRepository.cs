using EdenWhatsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace WhatsAppServer.Services
{
    public class MessageRepository : IMessageRepoistory
    {
        public Subject<MessageModel> MessageObservable { get; }

        public MessageRepository()
        {
            MessagesList = new List<MessageModel>();
            MessageObservable = new Subject<MessageModel>();
        }


        public void InsertMessage(MessageModel message)
        {
            MessageObservable.OnNext(message);
            MessagesList.Add(message);
        }

        public IObservable<MessageModel> StreamMessages()
        {
            throw new NotImplementedException();
        }

        public List<MessageModel> MessagesList { get; set; }
    }
}
