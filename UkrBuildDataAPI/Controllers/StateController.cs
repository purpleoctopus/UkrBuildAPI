using Microsoft.AspNetCore.Mvc;
using UkrBuildDataAPI.Data.Repository.Interfaces;

namespace UkrBuildDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IPostgreStateRepository _postgreState;

        public StateController(IPostgreStateRepository postgreState)
        {
            this._postgreState = postgreState;
        }
        [HttpGet]
        public async Task<IActionResult> GetStateAsync()
        {
            var dbState = await _postgreState.CheckConnection();

            if (dbState == false)
                return StatusCode(500, "Database error");

            return Ok();
        }
    }
}
