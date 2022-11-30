namespace CodePatternsBackend.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Rating { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
