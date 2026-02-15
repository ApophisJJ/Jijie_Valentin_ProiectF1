using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Race
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Race")]
        public string RaceName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime RaceDate { get; set; }

        [Required]
        [Display(Name = "Season")]
        public int SeasonID { get; set; }
        [Display(Name = "Season")]
        public Season? Season { get; set; }

        public ICollection<Result>? Results { get; set; }
    }
}
