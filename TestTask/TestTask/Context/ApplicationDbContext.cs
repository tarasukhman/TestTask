using Microsoft.EntityFrameworkCore;
using TestTask.Extensions;
using TestTask.Models;
using TestTask.ModelsConfiguration;

namespace TestTask.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public  DbSet<Country> Countries { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public  DbSet<Visit> Visits { get; set; }
        public DbSet<CountryVisitor> CountryVisitors { get; set; }
        public DbSet<VisitVisitor> VisitVisitors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CountryVisitorConfiguration());
            modelBuilder.ApplyConfiguration(new VisitConfiguration());
            modelBuilder.ApplyConfiguration(new VisitVisitorsConfiguration());
            modelBuilder.ApplyConfiguration(new VisitorConfiguration());

            modelBuilder.Seed();
            
        }
    }
}
