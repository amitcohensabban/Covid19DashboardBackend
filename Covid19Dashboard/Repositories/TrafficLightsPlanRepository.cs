using Covid19Dashboard.Data;
using Covid19Dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Covid19Dashboard.Repositories
{
    public class TrafficLightsPlanRepository:ITrafficLightsPlanRepository
    {
        private readonly CovidContext _context;

        public TrafficLightsPlanRepository(CovidContext context)
        {
            _context = context;
        }
        public async Task GenerateFakeData()
        {
            string[] israeliCities = new string[]
            {
                "בת ים",
                "יהוד",
                "אור יהודה",
                "קריית אונו",
                "זכרון יעקב",
                "קצרין",
                "תל מונד",
                "אילת",
                "רמת גן",
                "קרית אתא"
            };

            Random random = new Random();

            foreach (string city in israeliCities)
            {
                TrafficLightsPlan plan = new TrafficLightsPlan
                {
                    Id = Guid.NewGuid(),
                    City = city,
                    Grade = random.NextDouble(),
                    NewPatients = random.Next(100),
                    PositivePatients = random.Next(100),
                    RateOfChange = random.NextDouble(),
                    ActivePatients = random.Next(100)
                };

               await _context.TrafficLightsPlanTable.AddAsync(plan);
            }

           await _context.SaveChangesAsync();
        }

        public async Task<List<TrafficLightsPlan>> GetAllTrafficLightsPlan()
        {
            return await _context.TrafficLightsPlanTable.ToListAsync();
        }

    }
}

