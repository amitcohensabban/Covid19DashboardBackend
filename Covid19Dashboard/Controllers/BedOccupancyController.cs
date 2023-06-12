using Covid19Dashboard.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BedOccupancyController : ControllerBase
    {
        private readonly IBedOccupancyRepository _bedOccupancyRepository;

        public BedOccupancyController(IBedOccupancyRepository bedOccupancyRepository)
        {
            _bedOccupancyRepository = bedOccupancyRepository;
        }
        [HttpGet("")]
        public async Task <IActionResult> GetTable()
        {
            var res = await _bedOccupancyRepository.GetAllBedOccupanciesAsync();
            if (res?.Count > 0)
            {
                return Ok(res);
            }
            return NotFound();
        }
    }
}
