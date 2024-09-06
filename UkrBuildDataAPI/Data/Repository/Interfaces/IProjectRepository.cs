using UkrBuildAPI.Shared.Models.Domain;

namespace UkrBuildDataAPI.Data.Repository.Interfaces
{
    public interface IProjectRepository
    {
        public List<Project> GetAllProjects();
        public Project GetProjectById(int id);
    }
}
