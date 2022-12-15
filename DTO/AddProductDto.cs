using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CodePatternsBackend.Interfaces;

namespace CodePatternsBackend.DTO
{
    public class AddProductDto : IProduct
    {
        public int Rating { get; set; }
        [Required]
        public string Picture { get; set; } = "https://images.pexels.com/photos/1303084/pexels-photo-1303084.jpeg";
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
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
