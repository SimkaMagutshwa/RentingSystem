using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentingSystem.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = " Movie Cost")]
        public decimal Price { get; set; }

        [StringLength(5)]
        [Display(Name = "Rating")]
        public string Rating { get; set; }
        public ICollection<Registraction> Registractions { get; set; }
    }
}