using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkrBuildDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        public StateController()
        {
            
        }
        [HttpGet]
        public IActionResult GetState()
        {
            return Ok();
        }
    }
}
