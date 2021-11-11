using System.Collections.Generic;

namespace URLAliaser.Models.Entities
{
    public class HitCounter
    {
        public List<Link> Links { get; set; }
        public int HitCount { get; set; }
    }
}