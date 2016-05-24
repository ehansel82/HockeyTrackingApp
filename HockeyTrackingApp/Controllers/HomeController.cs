using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyTrackingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration=20)]
        public ActionResult Index()
        {
            ViewBag.handlerMessage = (string)HttpContext.Items["handlerMessage"] ?? string.Empty;
            return View();
        }
    }
}