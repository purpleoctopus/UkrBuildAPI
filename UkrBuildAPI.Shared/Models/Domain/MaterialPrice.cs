
namespace UkrBuildAPI.Shared.Models.Domain
{
    public class MaterialPrice
    {
        public Guid Id { get; set; }
        public Material Material { get; set; }
        public decimal Price { get; set; }
        public DateOnly Date { get; set; }
    }
}
