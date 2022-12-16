using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CodePatternsBackend.Interfaces;

namespace CodePatternsBackend.DTO
{
    // INTERFACE SEGGREGATION
    // This is used in the getallProducts request and in the Post
    // Using the IProduct interface to make sure I use everything I need.
    // In a project this size with DTOs I would normally skip the Interface to make it DRY
    public class ProductDto : IProduct
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        [Required]
        public string Picture { get; set; } = "https://images.pexels.com/photos/1303084/pexels-photo-1303084.jpeg";
        [Required]
        public string ProductName { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
