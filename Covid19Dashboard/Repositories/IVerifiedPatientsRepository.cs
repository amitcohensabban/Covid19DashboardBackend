using Covid19Dashboard.Models;

namespace Covid19Dashboard.Repositories
{
    public interface IVerifiedPatientsRepository
    {
         Task GenerateFakeVerifiedPatientsData();
        Task<List<VerifiedPatients>> GetAllVerifiedPatients();

    }
}
