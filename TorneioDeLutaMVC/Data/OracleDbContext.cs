
using Microsoft.EntityFrameworkCore;
using TorneioDeLutaMVC.Models;

namespace TorneioDeLutaMVC.Data
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Lutador> Lutadores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(NecessityMap).Assembly);
            modelBuilder.HasDefaultSchema("RM87725");
            base.OnModelCreating(modelBuilder);
        }
    }
}
