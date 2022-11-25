using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
