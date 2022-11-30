using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodePatternsBackend.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Rating { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public ProductCategoryEntity Category { get; set; } = null!;
        public int ProductCategoryEntityId { get; set; }
    }
}
