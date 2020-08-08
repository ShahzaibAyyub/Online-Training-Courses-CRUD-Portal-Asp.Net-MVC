using PNTS.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace PNTS.DAL
{
    public class PNTSContext : DbContext
    {
        public PNTSContext() : base("PNTSContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Register> Registrations { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}