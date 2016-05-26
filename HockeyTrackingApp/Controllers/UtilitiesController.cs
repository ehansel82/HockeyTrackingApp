using System.Web.Mvc;

namespace HockeyTrackingApp.Controllers
{
    public class UtilitiesController : Controller
    {
        public ActionResult Notifications()
        {
            return PartialView();
        }
    }
}