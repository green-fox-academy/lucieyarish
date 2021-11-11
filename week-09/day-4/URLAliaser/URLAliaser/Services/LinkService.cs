using System;
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
    }
}