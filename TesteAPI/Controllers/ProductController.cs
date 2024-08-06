using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAPI.Domains;
using TesteAPI.Repository;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        ProductRepository productRepository = new ProductRepository();

        [HttpPost]
        public IActionResult Post(Product product)
        {
            try
            {
                productRepository.Post(product);
                return Ok(product);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
    }
}
