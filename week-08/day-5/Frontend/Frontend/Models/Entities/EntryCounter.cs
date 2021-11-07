using System.Collections.Generic;

namespace Frontend.Models.Entities
{
    public class EntryCounter
    {
        public List<Log> Logs { get; set; }
        public int LogCount { get; set; }
    }
}