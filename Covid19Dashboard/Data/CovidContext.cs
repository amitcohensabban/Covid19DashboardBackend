
using Covid19Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;


namespace Covid19Dashboard.Data
{
    public class CovidContext:DbContext
    {
        public CovidContext(DbContextOptions<CovidContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.ClrType).HasNoKey();
            }

        }
        public DbSet<BedOccupancy> BedOccupancyTable { get; set; }
        public DbSet<VerifiedPatients> VerifiedPatientsTable { get; set; }
        public DbSet<TrafficLightsPlan> TrafficLightsPlanTable { get; set; }

    }
}
