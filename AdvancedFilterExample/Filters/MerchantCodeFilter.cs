using Microsoft.AspNetCore.Mvc.Filters;

namespace AdvancedFilterExample.Filters
{
    public class MerchantCodeFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //getdata
            var data = context.RouteData.Values["Merchant"].ToString();


            //set data


            await next();
        }
    }
}
