using Covid19Dashboard.Data;

namespace Covid19Dashboard.Repositories
{
    public class TrafficLightsPlanRepository:ITrafficLightsPlanRepository
    {
        private readonly CovidContext _context;

        public TrafficLightsPlanRepository(CovidContext context)
        {
            _context = context;
        }

    }
}
