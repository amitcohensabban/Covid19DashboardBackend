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


        [HttpPost("generate-data")]
        public async Task<IActionResult> GenerateFakeData()
        {
            await _verifiedPatientsRepository.GenerateFakeVerifiedPatientsData();
            return Ok("Fake data for VerifiedPatients table has been seeded.");
        }
        [HttpGet("")]
        public async Task<IActionResult> GetTable()
        {
            var res = await _verifiedPatientsRepository.GetAllVerifiedPatients();
            if (res?.Count > 0)
            {
                return Ok(res);
            }
            return NotFound();
        }

    }
}
