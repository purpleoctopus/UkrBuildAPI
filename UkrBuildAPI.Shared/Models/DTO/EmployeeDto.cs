using UkrBuildAPI.Shared.Enums;

namespace UkrBuildAPI.Shared.Models.DTO
{
    public class EmployeeDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public EmployeePosition Position { get; set; }
    }
}
