using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace BTL_Web.Models.Authentication
{
    public class Authentication_Client : ActionFilterAttribute
    {
                public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session.GetString("DNAd") != null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"Controller" ,"Access" },
                    {"Action" ,"Login" }
                });
            }


        }
    }
}
