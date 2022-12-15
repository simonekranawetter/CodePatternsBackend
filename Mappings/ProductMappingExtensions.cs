using CodePatternsBackend.DTO;
using CodePatternsBackend.Entities;
using System.Runtime.CompilerServices;

namespace CodePatternsBackend.Mappings
{   //SINGLE RESPONSIBILITY
    //Single Responsibility Principle: With that in mind I made mappings myself, to break them out of the Controller and make this class responsible for one thing which is Mappings.
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

        public static ProductDto MapToProductDto(this ProductEntity productEntity)
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

        public static ProductEntity MapToProductEntityWithNewCategory(this AddProductDto addProductDto)
        {
            var productEntity = new ProductEntity
            {
                Rating = addProductDto.Rating,
                Picture = addProductDto.Picture,
                ProductName = addProductDto.ProductName,
                BrandName = addProductDto.BrandName,
                Colors = addProductDto.Colors,
                Sizes = addProductDto.Sizes,
                Description = addProductDto.Description,
                Price = addProductDto.Price,
                Category = new ProductCategoryEntity
                {
                    Name = addProductDto.Category
                }
            };
            return productEntity;
        }


    }
}
