using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You Must Enter Your Social sequrity Number")]
        [Display(Name = "Social Sequrity Number")]
        [MaxLength(14), MinLength(14)]
        public string SSN { get; set; }
        
        [Required(ErrorMessage = "You must Enter your Name")]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must Enter your Email")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must Enter A password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public int? Balance { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime Date_Of_Birth { get; set; }
        
        public category Category { get; set; }
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
    }
}