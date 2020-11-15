using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdenWhatsApp.Models
{
    public class MessageModel
    {
        public MessageModel()
        {
            text = "";
        }
        public int clientID { get; set; }
        public string text { get; set; }
    }

}
