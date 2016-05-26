using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyTrackingApp.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public string Echo(string param)
        {
            return $"You typed {param}";
        }

        public string EncodeEcho(string param)
        {
            return $"You typed {HttpUtility.HtmlEncode(param)}";
        }

        public ActionResult CustomLayout()
        {
            return View();
        }
    }
}