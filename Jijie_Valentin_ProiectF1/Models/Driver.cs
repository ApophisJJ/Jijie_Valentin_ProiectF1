using System.ComponentModel.DataAnnotations;

namespace Jijie_Valentin_ProiectF1.Models
{
    public class Driver
    {
        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [Range(18, 50)]
        public int Age { get; set; }

        [Required]
        public int TeamID { get; set; }
        public Team? Team { get; set; }

        public ICollection<Result>? Results { get; set; }
    }
}
