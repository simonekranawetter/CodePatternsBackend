namespace CodePatternsBackend.DTO
{
    public class ProductDto
    {// TODO, change rating to number and add string picture
        public int Id { get; set; }
        public string? Rating { get; set; }
        //TODO, rename to ProductName 
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
