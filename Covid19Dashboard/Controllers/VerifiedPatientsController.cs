    using Covid19Dashboard.Repositories;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace Covid19Dashboard.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class VerifiedPatientsController : ControllerBase
        {
            private readonly IVerifiedPatientsRepository _verifiedPatientsRepository;

            public VerifiedPatientsController(IVerifiedPatientsRepository verifiedPatientsRepository)
            {
                _verifiedPatientsRepository = verifiedPatientsRepository;
            }


        [HttpPost("seed-data")]
        public async Task<IActionResult> SeedData()
        {
            await _verifiedPatientsRepository.SeedVerifiedPatientsData();
            return Ok("Fake data for VerifiedPatients table has been seeded.");
        }
    }
    }
