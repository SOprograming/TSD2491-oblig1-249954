using System.ComponentModel.DataAnnotations;

namespace TSD2591_oblig1_249954.Models
{
    public class Bruker
    {
        public int ID { get; set; }

        [Required]
        public string Navn { get; set; }

        [Required]
        public string KontaktInfo { get; set; }

        [Range(0, int.MaxValue)]
        public int AntallSpill { get; set; }
    }
}
