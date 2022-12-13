using CodePatternsBackend.DTO;
using CodePatternsBackend.Entities;

namespace CodePatternsBackend.Mappings
{ //COMMENT THIS SINGLE RESPONSIBILITY
    public static class ProductMappingExtensions
    {
        public static DetailedProductDto MapToDetailedProductDto(this ProductEntity productEntity)
        {
            var productDto = new DetailedProductDto
            {
                Id = productEntity.Id,
                Rating = productEntity.Rating,
                Picture = productEntity.Picture,
                ProductName = productEntity.ProductName,
                BrandName = productEntity.BrandName,
                Colors = productEntity.Colors,
                Sizes = productEntity.Sizes,
                Description = productEntity.Description,
                Price = productEntity.Price,
                Category = productEntity.Category.Name,
            };

            return productDto;
        }

        public static ProductDto MaptoProductDto(this ProductEntity productEntity)
        {
            var productDto = new ProductDto
            {
                Id = productEntity.Id,
                Rating = productEntity.Rating,
                Picture = productEntity.Picture,
                ProductName = productEntity.ProductName,
                Price = productEntity.Price,
                Category = productEntity.Category.Name,
            };

            return productDto;
        }
    }
}
