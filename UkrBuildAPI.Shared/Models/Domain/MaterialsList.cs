

namespace UkrBuildAPI.Shared.Models.Domain
{
    public class MaterialsList
    {
        public Guid Id { get; set; }
        public List<MaterialPrice> Materials { get; set; }
        public Project Project { get; set; }
    }
}
