using System.Globalization;
using System.Linq;
using Microsoft.AspNet.Mvc.Filters;
using System.Threading;

using WebApplication6.Helpers;
using WebApplication6.Infrastructure.Identity;

namespace WebApplication6.Filters
{
    //CUSTOM LOCALIZATION
    public class LanguageActionFilter : ActionFilterAttribute
    {
        public LanguageActionFilter()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string cultureName;
            var request = context.HttpContext.Request;
            var cultureCookie = request.Cookies[CultureHelper.CultureCookieName];

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                cultureName = PrincipalExtensions.GetCulture(context.HttpContext.User).Language;
                cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe
                CultureHelper.SetCookieToResponse(context, cultureName);
            }
            else
            {
                if (cultureCookie.Any())
                {
                    cultureName = cultureCookie[0];
                }
                else
                {
                    cultureName = request.Headers["Accept-Language"];
                    var cultures = CultureHelper.ParserHeaderAcceptedLanguage(cultureName);
                    var cultureFirst = cultures?.FirstOrDefault();

                    if (cultureFirst != null)
                        cultureName = cultureFirst.Value;

                    cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe
                    CultureHelper.SetCookieToResponse(context, cultureName);
                }
            }
            
#if DNX451 // if it is implemented, accept it
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
#elif DNXCORE50
            CultureInfo.CurrentCulture = new CultureInfo(cultureName);
            CultureInfo.CurrentUICulture = new CultureInfo(cultureName);
#else
#error No Implementation for the target DNX 
#endif

            base.OnActionExecuting(context);
        }
    }
}
