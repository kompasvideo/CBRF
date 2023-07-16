using CBRF_DB.Models.UFEBS_2023_4_1;
using Microsoft.EntityFrameworkCore;

namespace CBRF_DB
{
    sealed public class CbrDsigEnvV10ApplicationContext : DbContext
    {
        public DbSet<SigEnvelope> FSigEnvelope { get; set; }
        public CbrDsigEnvV10ApplicationContext()
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
