using Covid19Dashboard.Models;
namespace Covid19Dashboard.Repositories
{
    public interface IBedOccupancyRepository
    {
        Task GenerateFakeBedOccupancyData();
        Task<List<BedOccupancy>> GetAllBedOccupanciesAsync();
    }
}
