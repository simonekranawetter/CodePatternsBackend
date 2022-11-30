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
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts(string? category)
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
                var productDto = productEntity.MapToEntity();
                productDtos.Add(productDto);
            }
            return Ok(productDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var productEntity = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (productEntity == null) 
            {
                return NotFound();
            }

            var productDto = productEntity.MapToDto();

            return Ok(productDto);
        }
    }
}
