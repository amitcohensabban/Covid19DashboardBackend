using Covid19Dashboard.Data;
using Covid19Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19Dashboard.Repositories
{
    public class VerifiedPatientsRepository : IVerifiedPatientsRepository
    {
        private readonly CovidContext _context;

        public VerifiedPatientsRepository(CovidContext context)
        {
            _context = context;
        }

        public async Task GenerateFakeVerifiedPatientsData()
        {
            List<VerifiedPatients> fakeData = new List<VerifiedPatients>
            {
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 5000,
                    CountryName = "ברזיל",
                    VerifiedCitizens = 1000,
                    VerifiedForeigners = 2000,
                    VerifiedByTheIncoming = 50.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 4000,
                    CountryName = "ארגנטינה",
                    VerifiedCitizens = 800,
                    VerifiedForeigners = 1600,
                    VerifiedByTheIncoming = 40.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 3000,
                    CountryName = "קולומביה",
                    VerifiedCitizens = 600,
                    VerifiedForeigners = 1200,
                    VerifiedByTheIncoming = 30.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 2000,
                    CountryName = "פרו",
                    VerifiedCitizens = 400,
                    VerifiedForeigners = 800,
                    VerifiedByTheIncoming = 20.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 1500,
                    CountryName = "צ'ילה",
                    VerifiedCitizens = 300,
                    VerifiedForeigners = 600,
                    VerifiedByTheIncoming = 15.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 1200,
                    CountryName = "ונצואלה",
                    VerifiedCitizens = 240,
                    VerifiedForeigners = 480,
                    VerifiedByTheIncoming = 12.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 1000,
                    CountryName = "אקוודור",
                    VerifiedCitizens = 200,
                    VerifiedForeigners = 400,
                    VerifiedByTheIncoming = 10.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 800,
                    CountryName = "פרגוואי",
                    VerifiedCitizens = 160,
                    VerifiedForeigners = 320,
                    VerifiedByTheIncoming = 8.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 600,
                    CountryName = "בוליביה",
                    VerifiedCitizens = 120,
                    VerifiedForeigners = 240,
                    VerifiedByTheIncoming = 6.0,
                },
                new VerifiedPatients
                {
                    Id = Guid.NewGuid(),
                    EnteringIsrael = 400,
                    CountryName = "אורוגוואי",
                    VerifiedCitizens = 80,
                    VerifiedForeigners = 160,
                    VerifiedByTheIncoming = 4.0,
                },
            };

            foreach (var entity in fakeData)
            {
                await _context.VerifiedPatientsTable.AddAsync(entity);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<VerifiedPatients>> GetAllVerifiedPatients()
        {
            return await _context.VerifiedPatientsTable.ToListAsync();
        }
    }
}
