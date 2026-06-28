using CQRSWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSWebApi.Data
{
    public class InMemoryDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; } = default!;
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : base(options)
        {
            
        }
    }
}
