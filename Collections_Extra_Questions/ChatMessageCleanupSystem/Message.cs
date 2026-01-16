using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.ChatMessageCleanupSystem
{
    //message class
    public class Message
    {
        public string Data { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; }
        public bool IsStarred { get; set; }

        public Message(string data, DateTime sentDate, bool isRead, bool isStarred)
        {
            Data = data;
            Date = sentDate;
            IsRead = isRead;
            IsStarred = isStarred;
        }
    }
}