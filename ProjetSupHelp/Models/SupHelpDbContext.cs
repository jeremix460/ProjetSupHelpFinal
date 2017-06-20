using System.Data.Entity;


namespace ProjetSupHelp.Models
{
    public class SupHelpDbContext : DbContext
    {
        public DbSet<SupportDemand> Demands { get; set; }

        public DbSet<SupportProposition> Propositions { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Campus> Campus { get; set; }

        public DbSet<Availability> Availabilities { get; set; }

        public SupHelpDbContext() : base("SupHelpDbContext")
        {
            Database.SetInitializer<SupHelpDbContext>(new DbInitializer<SupHelpDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}