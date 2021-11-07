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
    }
}