using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Http;
using WebApplication6.Helpers;
using WebApplication6.Filters;

namespace WebApplication6.Controllers
{
    [ServiceFilter(typeof(LanguageActionFilter))]
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SetCulture(string culture)
        //{

        //    HttpContext.Response.Cookies.Append(CultureCookieName, culture, new CookieOptions
        //    {
        //        Expires = DateTime.Now.AddYears(1),
        //        Secure = false,

        //    });
        //    return RedirectToAction("Index");
        //}
    }
}
