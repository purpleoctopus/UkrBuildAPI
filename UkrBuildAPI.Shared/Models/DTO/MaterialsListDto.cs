using UkrBuildAPI.Shared.Models.Domain;

namespace UkrBuildAPI.Shared.Models.DTO
{
    public class MaterialsListDto
    {
        public List<MaterialPrice> Materials { get; set; }
        public Project Project { get; set; }
    }
}
