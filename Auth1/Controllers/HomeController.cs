using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth1.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        [Authorize(Roles = "admin")]
        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("Default", new { controller = "admin", });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        
    }
}