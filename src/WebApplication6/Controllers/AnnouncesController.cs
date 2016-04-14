using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using WebApplication6.Models;
using WebApplication6.Services;
using WebApplication6.ViewModels.Account;


namespace WebApplication6.Controllers
{
    [Authorize]
    //[Route("[controller]")] Removing controller name from URL
    [Route("")]
    public class AnnouncesController : Controller
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly IEmailSender _emailSender;
        //private readonly ISmsSender _smsSender;
        //private readonly ILogger _logger;


        //public AnnouncesController(
        //    UserManager<ApplicationUser> userManager,
        //    SignInManager<ApplicationUser> signInManager,
        //    IEmailSender emailSender,
        //    ISmsSender smsSender,
        //    ILoggerFactory loggerFactory)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //    _emailSender = emailSender;
        //    _smsSender = smsSender;
        //    _logger = loggerFactory.CreateLogger<AccountController>();
        //}

        //http://stackoverflow.com/questions/30951601/web-api-with-mvc-6-get-element-based-on-string
        [HttpGet("[action]/{placeID?}")]
        [AllowAnonymous]
        public IActionResult City(string placeID = null)
        {
            ViewData["PlaceID"] = placeID;
            return View();
        }
    }    
}
