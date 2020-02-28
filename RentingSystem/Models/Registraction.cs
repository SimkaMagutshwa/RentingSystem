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
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Occupation")]
        public string Occupation {get;set;}
        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = " Next of Kin First Name")]
        public string NextofKinLastName { get; set; }
        [Required]
        [Display(Name = " Next of Kin Phone Number")]
        public int NextofKinPhoneNumber { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }

}