using Microsoft.AspNetCore.Mvc;

namespace UkrBuildCrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetState()
        {
            return Ok();
        }
    }
}
