using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Team
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Team")]
        public string TeamName { get; set; }

        public ICollection<Driver>? Drivers { get; set; }
    }
}
