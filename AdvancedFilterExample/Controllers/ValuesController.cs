using Microsoft.AspNetCore.Mvc;

namespace AdvancedFilterExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok("Ok");
        }
    }
}
