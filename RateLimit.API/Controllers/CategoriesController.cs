using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(new { ID = 1, Categories= "Stationary" });
        }

        [HttpPost]
        public IActionResult AddCategories()
        {
            return Ok(new { Status = "Success" });
        }

        [HttpPut]
        public IActionResult UpdateCategories()
        {
            return Ok();
        }
    }
}
