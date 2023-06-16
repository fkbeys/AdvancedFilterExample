using Microsoft.AspNetCore.Mvc;

namespace AdvancedFilterExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        //[MerchantCodeFilter]
        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> Get()
        {

            return Ok("User data {a,b,c }");
        }
    }
}
