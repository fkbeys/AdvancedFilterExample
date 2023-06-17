﻿using AdvancedFilterExample.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdvancedFilterExample.Filters
{
    public class MerchantCodeFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //getdata
            string key = "merchantCode";
            string data = context.RouteData.Values[key].ToString();

            if (data.Length < 4)
            {
                throw new Exception("Merchant code can not be less then 4 characters...") { };
            }

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




            await next();
        }
    }
}
