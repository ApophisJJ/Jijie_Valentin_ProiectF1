using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Race
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string RaceName { get; set; }

        [DataType(DataType.Date)]
        public DateTime RaceDate { get; set; }

        [Required]
        public int SeasonID { get; set; }
        public Season? Season { get; set; }

        public ICollection<Result>? Results { get; set; }
    }
}
