using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_RViP_Ismagilova
{
    class Event
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int? Clock { get; set; }

        public Event(int id, string message, int? clock)
        {
            Id = id;
            Message = message;
            Clock = clock;
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Message: {1}, Clock: {2}\n", Id, Message, Clock);
        }
    }
}