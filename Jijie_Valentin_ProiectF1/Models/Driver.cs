using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Driver
    {
        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Range(18, 50)]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Team")]
        public int TeamID { get; set; }
        [Display(Name = "Team")]
        public Team? Team { get; set; }

        public ICollection<Result>? Results { get; set; }
    }
}
