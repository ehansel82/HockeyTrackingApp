using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.Models
{
    public class Player
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
    }
}