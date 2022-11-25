namespace CodePatternsBackend.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string? Rating { get; set; }
        public decimal Price { get; set; }
    }
}
