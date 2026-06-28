using Microsoft.EntityFrameworkCore;

namespace NonCQRSWebApi.Data
{
    public class InMemoryDbContext : DbContext
    {
        public DbSet<NonCQRSWebApi.Models.Player> Player { get; set; } = default!;
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options): base(options)
        {
            
        }
    }
}
