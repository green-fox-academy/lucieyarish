using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Log> DisplayLogs()
        {
            return new List<Log>(DbContext.Logs.ToList());
        }
        // public EntryCounter GetLogsCount()
        // {
        //     EntryCounter allLogs = new();
        //     allLogs.LogCount = DbContext.Logs.Count();
        //     foreach (var item in DbContext.Logs)
        //     {
        //         allLogs.Logs.Add(item);
        //     }
        //     return allLogs;
        // }
    }
}