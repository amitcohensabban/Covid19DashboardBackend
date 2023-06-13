using Covid19Dashboard.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrafficLightsPlanController : ControllerBase
    {
        private readonly ITrafficLightsPlanRepository _trafficLightsPlanRepository;

        public TrafficLightsPlanController(ITrafficLightsPlanRepository trafficLightsPlanRepository)
        {
            _trafficLightsPlanRepository = trafficLightsPlanRepository;
        }

        [HttpPost("generate-data")]
        public async Task<IActionResult> GenerateFakeData()
        {
            await _trafficLightsPlanRepository.GenerateFakeData();
            return Ok("Fake data for trafficLightsPlan table has been seeded.");

        }
        [HttpGet("")]
        public async Task<IActionResult> GetTable()
        {
            var res = await _trafficLightsPlanRepository.GetAllTrafficLightsPlan();
            if (res?.Count > 0)
            {
                return Ok(res);
            }
            return NotFound();
        }


    }
}
