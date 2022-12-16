using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodePatternsBackend.Entities
{   //SRP and OCP
    //This class is only responsible for Product Entity and is Extended by Product Category table
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
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
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public ProductCategoryEntity Category { get; set; } = null!;
        public int ProductCategoryEntityId { get; set; }

    }
}
