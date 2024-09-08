
namespace UkrBuildAPI.Shared.Models.DTO
{
    public class MaterialDto
    {
        public Guid? MaterialId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateOnly Date { get; set; }
    }
}
