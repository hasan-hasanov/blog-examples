using DAL.Configurations;
using DAL.Entities;
using DAL.Seed;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext()
        {
        }

        public PhoneBookContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<PhoneBookEntry> PhoneBookEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PhoneBookEntryConfig());
            modelBuilder.Entity<PhoneBookEntry>().HasData(new PhoneBookEntrySeed().PhoneBookEntries);

            base.OnModelCreating(modelBuilder);
        }
    }
}
