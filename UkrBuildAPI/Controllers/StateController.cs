using Microsoft.AspNetCore.Mvc;
using UkrBuildAPI.Services.Interfaces;

namespace UkrBuildAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IDataService dataService;

        public StateController(IDataService dataService)
        {
            this.dataService = dataService;
        }
        [HttpGet]
        public async Task<IActionResult> GetServerState()
        {
            string dataServiceState = await dataService.IsAvailable() ? "OK" : "FAIL";

            Object response = new { DataService = dataServiceState };

            return Ok(response);
        }
    }
}