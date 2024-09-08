using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UkrBuildAPI.CRM.Controllers
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
