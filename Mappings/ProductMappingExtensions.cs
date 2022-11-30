using CodePatternsBackend.DTO;
using CodePatternsBackend.Entities;

namespace CodePatternsBackend.Mappings
{
    public static class ProductMappingExtensions
    {
        public static ProductDto MapToDto(this ProductEntity productEntity)
        {
            var productDto = new ProductDto
            {
                Id = productEntity.Id,
                Rating = productEntity.Rating,
                Name = productEntity.Name,
                Description = productEntity.Description,
                Price = productEntity.Price,
                Category = productEntity.Category.Name,
            };

            return productDto;
        }
    }
}
