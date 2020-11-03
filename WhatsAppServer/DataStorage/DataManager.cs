using EdenWhatsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdenWhatsApp.DataStorage
{
    public static class DataManager
    {
        public static List<MessageModel> GetData()
        {
            return new List<MessageModel> { 
                new MessageModel(){text = "בדיקה1" },
                new MessageModel(){text = "בדיקה3" }
            };
        }
    }
}
