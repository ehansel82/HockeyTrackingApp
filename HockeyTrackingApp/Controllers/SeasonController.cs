using HockeyTrackingApp.Models;
using HockeyTrackingApp.Models.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HockeyTrackingApp.Controllers
{
    public class SeasonController : Controller
    {
        private List<KeyValuePair<string, short>> _years;

        public SeasonController()
        {
            _years = new List<KeyValuePair<string, short>>();
            _years.Add(new KeyValuePair<string, short>("2016", 2016));
            _years.Add(new KeyValuePair<string, short>("2015", 2015));
        }

        // GET: Season
        public ActionResult Index()
        {
            IEnumerable<Season> seasons;
            using (var ctx = new HockeyAppContext())
            {
                seasons = ctx.Seasons.ToList();
            }
            return View(seasons);

        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Years = new SelectList(_years, "key", "value", 2016);
            return View();
        }

        [HttpPost]
        public ActionResult Create(Season season)
        {
            if (ModelState.IsValid)
            {
                using (var ctx = new HockeyAppContext())
                {
                    ctx.Seasons.Add(season);
                    ctx.SaveChanges();
                }
            }
            ViewBag.Years = new SelectList(_years, "key", "value", 2016);
            return View();
        }
    }
}