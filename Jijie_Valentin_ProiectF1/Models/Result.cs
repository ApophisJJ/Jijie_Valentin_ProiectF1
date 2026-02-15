using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Result
    {
        public int ID { get; set; }

        [Range(1, 20)]
        [Display(Name = "Position")]
        public int Position { get; set; }
        
        [Range(0, 25)]
        [Display(Name = "Points")]
        public int Points { get; set; }

        // FK Driver
        [Required]
        [Display(Name = "Driver")]
        public int DriverID { get; set; }
        [Display(Name = "Driver")]
        public Driver? Driver { get; set; }

        // FK Race
        [Required]
        [Display(Name = "Race")]
        public int RaceID { get; set; }
        [Display(Name = "Race")]
        public Race? Race { get; set; }
    }
}
