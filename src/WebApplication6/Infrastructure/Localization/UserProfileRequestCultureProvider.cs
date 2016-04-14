using System;
using System.Globalization;
using System.Threading.Tasks;
using WebApplication6.Infrastructure.Identity;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Localization;
using System.Collections.Generic;

namespace WebApplication6.Infrastructure.Localization
{
    public class UserProfileRequestCultureProvider : RequestCultureProvider
    {
        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            if (!httpContext.User.Identity.IsAuthenticated)
                return Task.FromResult((ProviderCultureResult)null);

            var culturePreferences = httpContext.User.GetCulture();
            if (culturePreferences == null)
                return Task.FromResult((ProviderCultureResult)null);


            var uiCulture = new CultureInfo(culturePreferences.Language);
            var culture = new CultureInfo(culturePreferences.Language);

            //if (!string.IsNullOrEmpty(culturePreferences.ShortDateFormat))
            //    culture.DateTimeFormat.ShortDatePattern = culturePreferences.ShortDateFormat;
            //if (!string.IsNullOrEmpty(culturePreferences.LongDateFormat))
            //    culture.DateTimeFormat.LongDatePattern = culturePreferences.LongDateFormat;
            //if (!string.IsNullOrEmpty(culturePreferences.CurrencySymbol))
            //    culture.NumberFormat.CurrencySymbol = culturePreferences.CurrencySymbol;

            var requestCulture = new ProviderCultureResult(culturePreferences.Language);
           
            return Task.FromResult(requestCulture);
        }
    }
}