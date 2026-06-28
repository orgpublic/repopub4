using Microsoft.EntityFrameworkCore;

namespace CQRSWebApi.Data
{
    public class InMemoryDbContext : DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : base(options)
        {
            
        }
    }
}
