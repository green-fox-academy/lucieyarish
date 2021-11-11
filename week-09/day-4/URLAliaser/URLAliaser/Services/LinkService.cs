using URLAliaser.Models.Entities;
using URLAliaser.Persistence;

namespace URLAliaser.Services
{
    public class LinkService
    {
        private ApplicationDbContext DbContext { get; set; }

        public LinkService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public Link SaveLink(Link link)
        {
            var savedLink = DbContext.Links.Add(link).Entity;
            DbContext.SaveChanges();
            return savedLink;
        }
    }
}