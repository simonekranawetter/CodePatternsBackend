using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CodePatternsBackend.Interfaces;

namespace CodePatternsBackend.DTO
{
    // OPEN CLOSED PRINCIPLE
    // Classes should be open for extension but closed for modification, this is why I added another DTO here to only request detailed information when needed and this also extends the ProductDto instead of having to change the ProductDto
    public class DetailedProductDto : IProduct
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public string ProductName { get; set; } = null!;
        [Required]
        public string BrandName { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string Colors { get; set; } = null!;
        [Required]
        public string Sizes { get; set; } = null!;
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
