using System.ComponentModel.DataAnnotations;

namespace CodePatternsBackend.Entities
{
    public class ProductCategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}
