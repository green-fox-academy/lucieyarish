using System;

namespace Frontend.Models.Entities
{
    public class Log
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }
    }
}