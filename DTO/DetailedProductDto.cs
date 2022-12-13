using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CodePatternsBackend.Interfaces;

namespace CodePatternsBackend.DTO
{
    // TODO COMMENT THIS open close principle
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
