using Microsoft.AspNetCore.Mvc;

namespace AdvancedFilterExample.Controllers
{
    [Route("api/{merchantCode}/[controller]")]
    [ApiController]

    public class MerchantController : ControllerBase
    {


        [HttpGet()]
        [Route("GetUsers")]
        public async Task<IActionResult> Get()
        {

            return Ok("User data {a,b,c }");
        }
    }
}
