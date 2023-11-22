using EFCore_Models.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore_DataAccess.Data
{
    /// <summary>
    /// DbSet name will be considered as table name
    /// </summary>
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Project> ProjectInfo { get; set; }
        public DbSet<VersionandMeta> VersionInfo { get; set; }
        public DbSet<Execution> ExecutionInfo { get; set; }
        public DbSet<TestCase> TestInfo { get; set; }

        //public DbSet<UseCaseDict> useCaseDicts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=GRLAnalyticsDB;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Updates the precision for a particular property in a model
            //modelBuilder.Entity<Execution>().Property(x => x.ExecutionIndex).HasPrecision(10, 5);
            modelBuilder.Entity<Execution>().HasData(new Execution(1, "Run1", "samplepath"));
        }
    }
}