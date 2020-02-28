using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentingSystem.Models
{
    public class RentingDetails
    {
        public int ID { get; set; }
        public string RenterFirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string MovieTitle { get; set; }
        public string NumberofMovies { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        public string Duration { get; set; }

       
    }
}