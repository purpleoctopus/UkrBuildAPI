using Microsoft.AspNetCore.Mvc;
using UkrBuildDataAPI.Data.Repository.Interfaces;

namespace UkrBuildDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository) 
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var response = await employeeRepository.GetAllEmployees();

            if (response == null) 
            { 
                return NotFound();
            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await employeeRepository.GetEmployeeById(id);

            if(response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
