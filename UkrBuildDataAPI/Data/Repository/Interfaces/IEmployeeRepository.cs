using UkrBuildAPI.Shared.Models.Domain;

namespace UkrBuildDataAPI.Data.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployees();
        public Task<Employee> GetEmployeeById(Guid id);

        public Task<Employee> AddEmployee(Employee employee);
    }
}
