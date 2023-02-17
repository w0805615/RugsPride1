using Microsoft.EntityFrameworkCore;
using RugsPride.Models;

namespace RugsPride.Data
{
    public class RugsPrideContext : DbContext
    {
        public RugsPrideContext (DbContextOptions<RugsPrideContext> options)
            : base(options)
        {
        }

        public DbSet<Rug> Rug{get; set; }
    }
}