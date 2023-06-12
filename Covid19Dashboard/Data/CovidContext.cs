
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
        public DbSet<BedOccupancy> BedOccupancyTable { get; set; }
        public DbSet<VerifiedPatients> VerifiedPatientsTable { get; set; }
        public DbSet<TrafficLightsPlan> TrafficLightsPlanTable { get; set; }

    }
}
