using System.Collections.Generic;
using URLAliaser.Models.Entities;

namespace URLAliaser.ViewModels
{
    public class LinkViewModel
    {
        public Link Link { get; set; }
        public List<Link> Links { get; set; }
    }
}