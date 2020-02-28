using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentingSystem.Models
{
    public class Registraction
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Occupation {get;set;}
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string NextofKinLastName { get; set; }
        [Required]
        public int NextofKinPhoneNumber { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }

}