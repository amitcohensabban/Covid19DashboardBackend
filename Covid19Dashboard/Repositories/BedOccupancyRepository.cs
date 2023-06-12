using Covid19Dashboard.Data;
using Covid19Dashboard.Models;
using Microsoft.EntityFrameworkCore;


namespace Covid19Dashboard.Repositories
{
    public class BedOccupancyRepository:IBedOccupancyRepository
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
    }
}
