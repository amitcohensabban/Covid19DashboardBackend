using Covid19Dashboard.Models;

namespace Covid19Dashboard.Repositories
{
    public interface ITrafficLightsPlanRepository
    {
        Task GenerateFakeData();
        Task<List<TrafficLightsPlan>> GetAllTrafficLightsPlan();
    }
}
