using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripAdvisor.Models
{
    public class Restaurant
    {

        public int Id { get; set; }

        [Display(Name = "Restaurant Name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Location { get; set; }

        [RegularExpression(@"^[1-5]")]
        public int Rating { get; set; }

        [RegularExpression(@"^[A-Za-z,]")]
        [StringLength(40)]
        public string Cuisine { get; set; }
    }
}
