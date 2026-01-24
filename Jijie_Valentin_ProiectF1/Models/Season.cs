using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Season
    {
        public int ID { get; set; }

        [Required]

        [Range(1950, 2025)]
        public int SeasonYear { get; set; }

        // Navigation
        public ICollection<Race>? Races { get; set; }

        public override string ToString()
        {
            return SeasonYear.ToString();
        }
    }
}
