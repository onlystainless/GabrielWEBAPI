using Microsoft.AspNetCore.Mvc;

namespace GabrielWEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GabrielController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var result = new
            {
                name = "Gabriel",
                message = "Hello, this is my WebAPI!"
            };

            return Ok(result);
        }
    }
}