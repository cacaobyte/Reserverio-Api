using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Reserverio.Api.Attribute
{
    public class StaticMiddleware
    {
        public class AppKeyOnlyFilter : ActionFilterAttribute
        {
            private const string AppKeyHeaderName = "AppKey";


            public override void OnActionExecuting(ActionExecutingContext context)
            {
                var hasAppKey = context.HttpContext.Request.Headers.TryGetValue(AppKeyHeaderName, out var extractedAppKey);

                if (!hasAppKey || string.IsNullOrWhiteSpace(extractedAppKey))
                {
                    context.Result = new ContentResult()
                    {
                        StatusCode = 400,
                        Content = "Missing or empty ApiKey header"
                    };
                    return;
                }



                base.OnActionExecuting(context);
            }
        }
    }
}
