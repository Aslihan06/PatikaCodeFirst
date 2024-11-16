using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirst.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Platform { get; set; }

        [Range(0, 10)]
        public decimal Rating { get; set; }
    }
}

