using AdvancedFilterExample.Filters;
using AdvancedFilterExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedFilterExample.Controllers
{
    [Route("api/{merchantCode}/[controller]")]
    [ApiController]

    public class MerchantController : ControllerBase
    {


        [HttpGet()]
        [Route("GetUsers")]
        public async Task<IActionResult> Get(string merchantCode)
        {

            return Ok($"User data listed for: {merchantCode} ");
        }

        [MerchantCodeActionFilterAttribute]
        [HttpPost]
        [Route("UpdateMerchant")]
        public async Task<IActionResult> UpdateMerchant(MerchantUpdateModel merchant)
        {
            return Ok($"User data updated for: {merchant.code} ");
        }


    }
}
