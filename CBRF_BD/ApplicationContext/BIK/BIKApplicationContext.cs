using CBRF_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace CBRF_DB
{
    sealed public class BIKApplicationContext : DbContext
    {
        public DbSet<BICDirectoryEntry> FBICDirectoryEntry { get; set; }
        public DbSet<ParticipantInfo> FParticipantInfo { get; set; }
        public DbSet<RstrList> FRstrList { get; set; }
        public DbSet<SWBICS> FSWBICS { get; set; }
        public DbSet<Accounts> FAccounts { get; set; }
        public DbSet<AccRstrList> FAccRstrList { get; set; }
        public BIKApplicationContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Properties.Resources.ConnectionStringDb);
        }
    }
}
