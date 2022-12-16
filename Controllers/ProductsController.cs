using CodePatternsBackend.Data;
using CodePatternsBackend.DTO;
using CodePatternsBackend.Entities;
using CodePatternsBackend.Mappings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodePatternsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //DEPENDENCY INVERSION
    //To make the class more abstract logger and context are made private here
    //Also Single Responsibility Principle as far as possible
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly SqlContext _context;

        public ProductsController(ILogger<ProductsController> logger, SqlContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetAllProducts")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts(string? category)
        {
            IQueryable<ProductEntity> productQuery = _context.Products.Include(p => p.Category);

            if (category != null)
            {
                productQuery = productQuery.Where(p => p.Category.Name == category);
            }

            var productEntities = await productQuery.ToListAsync();
            List<ProductDto> productDtos = new List<ProductDto>();

            foreach (var productEntity in productEntities)
            {
                var productDto = productEntity.MapToProductDto();
                productDtos.Add(productDto);
            }
            return Ok(productDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetailedProductDto>> GetProduct(int id)
        {
            var productEntity = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (productEntity == null)
            {
                return NotFound();
            }

            var productDto = productEntity.MapToDetailedProductDto();

            return Ok(productDto);
        }

        //This entire post request is only here so I could add stuff to the database for testing purposes
        //I tried to make it as dry as possible but haven't figured out the mapping for the below fully yet
        [HttpPost(Name = "AddProduct")]
        public async Task<ActionResult<AddProductDto>> AddProduct(AddProductDto addProductDto)
        {
            if (await _context.Products.AnyAsync(p => p.ProductName == addProductDto.ProductName))
            {
                return BadRequest();
            }
            var productCategory = await _context.ProductCategories.FirstOrDefaultAsync(p => p.Name == addProductDto.Category);
            ProductEntity productEntity;

            if (productCategory == null)
            {
                productEntity = addProductDto.MapToProductEntityWithNewCategory();
            }
            //Todo figure out how to map this nicely
            else 
            {
                productEntity = new ProductEntity
                {
                    Rating = addProductDto.Rating,
                    Picture = addProductDto.Picture,
                    ProductName = addProductDto.ProductName,
                    BrandName = addProductDto.BrandName,
                    Colors = addProductDto.Colors,
                    Sizes = addProductDto.Sizes,
                    Description = addProductDto.Description,
                    Price = addProductDto.Price,
                    ProductCategoryEntityId = productCategory.Id,
                };
            }

            _context.Products.Add(productEntity);
            await _context.SaveChangesAsync();

            var detailedProductDto = productEntity.MapToDetailedProductDto();
            return CreatedAtAction("GetProduct", new { id = productEntity.Id }, detailedProductDto);
        }
    }
}

