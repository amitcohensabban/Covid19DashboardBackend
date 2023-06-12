using Covid19Dashboard.Models;
namespace Covid19Dashboard.Repositories
{
    public interface IBedOccupancyRepository
    {
        Task<List<BedOccupancy>> GetAllBedOccupanciesAsync();
    }
}
