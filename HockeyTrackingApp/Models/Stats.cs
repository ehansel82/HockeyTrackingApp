using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.Models
{
    public class Stats
    {
        public int ID { get; set; }
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int PenaltyMinutes { get; set; }
    }
}