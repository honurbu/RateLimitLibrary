using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(new { Id = 1, Name = "Pencil", Price=60 });
        }

        //GEt api/product/pencil/20 gibi sorgu. Tek parametre gönderirsen 404 döner.
        [HttpGet("{name}/{price}")]
        public IActionResult GetProduct(string name, int price)
        {
            return Ok(name);
        }
    }
}
