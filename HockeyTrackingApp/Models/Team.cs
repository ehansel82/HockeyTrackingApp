using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.Models
{
    public class Team
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual List<Player> Players { get; set; }
        public virtual Season Season { get; set; }
        public virtual Player Captain { get; set; }
    }
}