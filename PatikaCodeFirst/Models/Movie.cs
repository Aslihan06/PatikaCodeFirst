using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirst.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }
    }
}

