using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdenWhatsApp.Models
{
    public class MessageModel
    {
        public MessageModel(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }

}
