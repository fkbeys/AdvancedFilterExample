using AdvancedFilterExample.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdvancedFilterExample.Filters
{
    public class MerchantCodeActionFilterAttribute : ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //getdata
            string key = "merchantCode";
            var data = context.RouteData.Values[key].ToString();


            //set data
            //we find the base class of the model
            var baseRequest = context.ActionArguments.FirstOrDefault(x => x.Value != null && typeof(MerchantBase).IsAssignableFrom(x.Value.GetType()));

            if (baseRequest!.Value != null)
            {
                var req = baseRequest.Value as MerchantBase;
                req.code = data;
                //data = req.code;
            }
            else
            {
                if (!context.ActionArguments.ContainsKey(key))
                    context.ActionArguments.Add(key, data);
                else context.ActionArguments[key] = data;
            }

            return base.OnActionExecutionAsync(context, next);
        }

    }
}
