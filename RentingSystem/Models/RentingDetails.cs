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
        [Display(Name = " Renter's First Name")]
        public string RenterFirstName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = " Movie Title")]
        public string MovieTitle { get; set; }
        [Display(Name = "Number of Hired Movies")]
        public string NumberofMovies { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }

        [Display(Name = " Duration")]
        public string Duration { get; set; }

       
    }
}