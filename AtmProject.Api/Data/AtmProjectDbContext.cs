using AtmProject.Api.Data.Configurations;
using AtmProject.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AtmProject.Api.Data
{
    public class AtmProjectDbContext:DbContext
    {
        public AtmProjectDbContext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<City>  City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CityConfiguration());
        }
    }
}
