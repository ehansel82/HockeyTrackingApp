using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.Models
{
    public class Season
    {
        public int ID { get; set; }
        public string SeasonName { get; set; }
        public short Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Team> Teams { get; set; }
    }
}