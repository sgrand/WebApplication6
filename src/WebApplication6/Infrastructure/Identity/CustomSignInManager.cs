using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication6.Infrastructure.Localization;
using WebApplication6.Models;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using Microsoft.Extensions.OptionsModel;
using Microsoft.Extensions.Logging;

namespace WebApplication6.Infrastructure.Identity
{
    public class CustomSignInManager : SignInManager<ApplicationUser>
    {
        public CustomSignInManager(UserManager<ApplicationUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<ApplicationUser>> logger)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
        {
        }

        public override async Task<ClaimsPrincipal> CreateUserPrincipalAsync(ApplicationUser user)
        {
            var principal = await base.CreateUserPrincipalAsync(user);

            var identity = principal.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userPreferences = new UserCulturePreferences
                {
                    Language = user.Language,
                    //ShortDateFormat = user.ShortDateFormat,
                    //LongDateFormat = user.LongDateFormat,
                    //CurrencySymbol = user.CurrencySymbol
                };

                if (!string.IsNullOrEmpty(user.Language))
                    identity.AddClaim(new Claim("localizationapp:cultureprefs", JsonConvert.SerializeObject(userPreferences)));
            }

            return principal;
        }
    }
}