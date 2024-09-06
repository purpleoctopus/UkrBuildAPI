using Microsoft.EntityFrameworkCore;
using UkrBuildAPI.Shared.Models.Domain;
using UkrBuildDataAPI.Data.Repository.Interfaces;

namespace UkrBuildDataAPI.Data.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PostgreContext _context;

        public EmployeeRepository(PostgreContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            List<Employee> result;

            result = await _context.Employees.ToListAsync();

            return result;
        }

        public async Task<Employee> GetEmployeeById(Guid id)
        {
            Employee? result;

            result = await _context.Employees.FirstOrDefaultAsync(_ => _.Id == id);

            return result;
        }
    }
}
