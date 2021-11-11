using System;
using System.Collections.Generic;
using System.Linq;
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
            int secretCode = GenerateRandomCode();
            var linkToSave = link;
            linkToSave.SecretCode = secretCode;
            var saveToDb = DbContext.Links.Add(linkToSave).Entity;
            DbContext.SaveChanges();
            return saveToDb;
        }

        public int GenerateRandomCode()
        {
            int min = 1000;
            int max = 9999;
            Random random = new Random();
            return random.Next(min, max);
        }

        public List<Link> FindALl()
        {
            return DbContext.Links.ToList();
        }
        public bool CheckIfExists(Link link)
        {
            // var checkedAlias = 
            //     FindALl()
            //     .Where(a => a.Alias == link.Alias)
            //     .ToList();
            if (!DbContext.Links.Contains(link))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}