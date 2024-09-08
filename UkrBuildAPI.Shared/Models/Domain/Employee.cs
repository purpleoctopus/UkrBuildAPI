using UkrBuildAPI.Shared.Enums;

namespace UkrBuildAPI.Shared.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public EmployeePosition Position { get; set; }
    }
}
