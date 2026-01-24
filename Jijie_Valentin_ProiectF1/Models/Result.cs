using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Result
    {
        public int ID { get; set; }

        [Range(1, 20)]
        public int Position { get; set; }
        
        [Range(0, 25)]
        public int Points { get; set; }

        // FK Driver
        [Required]
        public int DriverID { get; set; }
        public Driver? Driver { get; set; }

        // FK Race
        [Required]
        public int RaceID { get; set; }
        public Race? Race { get; set; }
    }
}
