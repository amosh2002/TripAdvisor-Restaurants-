using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripAdvisor.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
    }
}
