using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication6.Models;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using WebApplication6.Filters;
using WebApplication6.Helpers;
using System.Globalization;

//http://techiejourney.com/asp-net-5-view-components-building-a-bootstrap-navigation-menu/

public class LanguageMenuViewComponent : ViewComponent
{
    private readonly UserManager<ApplicationUser> _userManager;

    public LanguageMenuViewComponent(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public IViewComponentResult Invoke()
    {
        var language = CultureHelper.GetCurrentNeutralCulture();
        
        var viewModel = new ConfigureCultureInfoViewModel
        {
            Culture = language,
            UICulture = language
        };

        return View(viewModel);

    }


    //public async Task<IActionResult> ConfigureCultureInfo()
    //{
    //    var user = await _userManager.FindByIdAsync(User.GetUserId());

    //    var viewModel = new ConfigureCultureInfoViewModel
    //    {
    //        Culture = user.Language,
    //        UICulture = user.Language
    //    };

    //    return PartialView(viewModel);
    //}

    //public async Task<IActionResult> ConfigureCultureInfo(ConfigureCultureInfoViewModel viewModel)
    //{
    //    var user = await _userManager.FindByIdAsync(User.GetUserId());
    //    user.Language = viewModel.Culture;
    //    user.Language = viewModel.UICulture;

    //    await _userManager.UpdateAsync(user);

    //    return RedirectToAction("Index");
    //}
}