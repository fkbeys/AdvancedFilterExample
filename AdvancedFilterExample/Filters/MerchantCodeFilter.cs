using Microsoft.AspNetCore.Mvc.Filters;

namespace AdvancedFilterExample.Filters
{
    public class MerchantCodeFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //getdata
            string key = "merchantCode";
            var data = context.RouteData.Values[key].ToString();


            //set data
            if (context.ActionArguments.ContainsKey(key))
                context.ActionArguments.Add(key, data);
            else context.ActionArguments[key] = data;


            await next();
        }
    }
}
