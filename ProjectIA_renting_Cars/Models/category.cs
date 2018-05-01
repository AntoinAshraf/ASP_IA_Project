using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.Models
{
    public class category
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "You have to enter the category name")]
        [Display(Name = "Category Name")]
        public string category_Name { get; set; }
    }
}