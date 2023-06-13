using Covid19Dashboard.Data;
using Covid19Dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Covid19Dashboard.Repositories
{
    public class BedOccupancyRepository : IBedOccupancyRepository
    {
        private readonly CovidContext _context;

        public BedOccupancyRepository(CovidContext context)
        {
            _context = context;
        }

        public async Task<List<BedOccupancy>> GetAllBedOccupanciesAsync()
        {
            return await _context.BedOccupancyTable.ToListAsync();
        }

        public async Task GenerateFakeBedOccupancyData()
        {
            List<BedOccupancy> fakeData = new List<BedOccupancy>
            {
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "איכילוב",
                    GeneralOccupancy = 50.0,
                    InternalMedicineOccupancy = 40.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "וולפסון",
                    GeneralOccupancy = 45.0,
                    InternalMedicineOccupancy = 35.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "שיבא",
                    GeneralOccupancy = 35.0,
                    InternalMedicineOccupancy = 30.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "זיו",
                    GeneralOccupancy = 40.0,
                    InternalMedicineOccupancy = 25.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "יוספטל",
                    GeneralOccupancy = 30.0,
                    InternalMedicineOccupancy = 20.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "מעייני הישועה",
                    GeneralOccupancy = 25.0,
                    InternalMedicineOccupancy = 15.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "הדסה הר הצופים",
                    GeneralOccupancy = 20.0,
                    InternalMedicineOccupancy = 12.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "הדסה עין כרם",
                    GeneralOccupancy = 15.0,
                    InternalMedicineOccupancy = 10.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "רמבם",
                    GeneralOccupancy = 10.0,
                    InternalMedicineOccupancy = 8.0,
                },
                new BedOccupancy
                {
                    Id = Guid.NewGuid(),
                    HospitalName = "סורוקה",
                    GeneralOccupancy = 8.0,
                    InternalMedicineOccupancy = 5.0,
                }
            };

            foreach (var entity in fakeData)
            {
                await _context.BedOccupancyTable.AddAsync(entity);
            }

            await _context.SaveChangesAsync();
        }
    }
}
