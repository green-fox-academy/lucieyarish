using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            foreach (var item in DbContext.Links)
            {
                if (item.Alias == link.Alias)
                {
                    return true;
                }
            }
            return false;
        }

        // public string VisitLink(string alias)
        // {
        //     var foundAlias = FindALl()
        //         .Where(l => l.Alias == alias);
        //     var foundLink = foundAlias.Where(a => a.LinkURL).ToString();
        //     return foundLink;
        // }

        public string FindByAlias(string alias)
        {
            var foundAlias = DbContext.Links.Where(a => a.Alias == alias).FirstOrDefault();
            return foundAlias.LinkURL;
        }

        public bool CheckIfAliasExists(string alias)
        {
            var foundAlias = DbContext.Links.Contains(alias);
        }
    }
}