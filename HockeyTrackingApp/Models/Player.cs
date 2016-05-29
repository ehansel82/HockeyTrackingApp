using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HockeyTrackingApp.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(2)]
        public string Number { get; set; }
        public bool isCaptain { get; set; }
        public virtual List<Stats> Stats { get; set; }
        public virtual Team Team { get; set; }
    }
}