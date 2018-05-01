using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Car must have a model number")]
        [Display(Name = "Car Model")]
        public string Car_Model { get; set; }

        [Required(ErrorMessage = "The Car must have Name")]
        [Display(Name = "Car Name")]
        public string Car_Name { get; set; }

        [Display(Name = "Car Color")]
        public string Car_Color { get; set; }

        [Display(Name = "Car Photo")]
        public byte?[] Car_Photo { get; set; }

        [Required(ErrorMessage = "The Car must have a Price")]
        [Display(Name = "Rent Price")]
        public float Price { get; set; }

        public category category { get; set; }
        [Required(ErrorMessage = "The Car must be in a category")]
        [Display(Name = "Car Category")]
        public int categoryId { get; set; }

        public User User { get; set; }
        [Display(Name = "Renter Id")]
        public int? UserId { get; set; }

        [Display(Name = "Rent Date")]
        public DateTime? Rented_From { get; set; }
        [Display(Name = "Rent Due Date")]
        public DateTime? Rented_Till { get; set; }
    }
}