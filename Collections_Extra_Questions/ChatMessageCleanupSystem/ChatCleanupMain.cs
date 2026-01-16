using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.ChatMessageCleanupSystem
{
    public class ChatCleanupMain
    {
        public static void Execute()
        {
            Dictionary<string, LinkedList<Message>> data = new Dictionary<string, LinkedList<Message>>();
            data["user1"] = new LinkedList<Message>(
                new List<Message>
                {
                    new Message("hello",DateTime.Now.AddDays(-10),false,false),
                    new Message("bye",DateTime.Now.AddDays(-20),true,false),
                    new Message("how are you",DateTime.Now.AddDays(-30),true,true),
                    new Message("happy new year",DateTime.Now.AddDays(-40),true,false),
                }
            );

            ChatCleanup service = new ChatCleanup(data);
            service.Delete();

            Console.WriteLine("Last 2 Messages for user1:\n");
            var lastMessages = service.GetLastMessages("user1", 2);
            foreach (var msg in lastMessages)
            {
                Console.WriteLine($"{msg.Data} | {msg.Date.ToShortDateString()}");
            }
        }
    }
}