using ProjectIA_renting_Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIA_renting_Cars.ViewModels
{
    public class UserCategoryViewModel
    {
        public User User { get; set; }
        public IEnumerable<category> categories { get; set; }
    }
}