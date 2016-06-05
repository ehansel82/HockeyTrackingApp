using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.Models
{
    public class Season
    {
        public int ID { get; set; }
        public string SeasonName { get; set; }
        public short Year { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        public virtual List<Team> Teams { get; set; }
    }
}