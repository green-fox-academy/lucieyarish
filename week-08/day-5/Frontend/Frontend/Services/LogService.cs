using System;
using Frontend.Models.Entities;
using Frontend.Persistence;

namespace Frontend.Services
{
    public class LogService
    {
        private ApplicationDbContext DbContext { get; }

        public LogService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void AddLog(string endpoint, string data)
        {
            DbContext.Logs.Add(new Log {CreatedAt = DateTime.Now, EndPoint = endpoint, Data = data});
            DbContext.SaveChanges();
        }
    }
}