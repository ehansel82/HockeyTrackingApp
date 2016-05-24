using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int CaptainID { get; set; }
    }
}