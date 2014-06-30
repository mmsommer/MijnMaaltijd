using MijnMaaltijd.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MijnMaaltijd.DAL
{
    public class MijnMaaltijdContext : DbContext
    {
        public MijnMaaltijdContext()
            : base("Entities")
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<MijnMaaltijd.Models.Type> Types { get; set; }
        public DbSet<Season> Seasons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
