using UkrBuildAPI.Shared.Models.Domain;

namespace UkrBuildAPI.Shared.Models.DTO
{
    public class ProjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Employee Manager { get; set; }
    }
}
