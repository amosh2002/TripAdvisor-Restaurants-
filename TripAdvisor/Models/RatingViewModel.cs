using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripAdvisor.Models
{
    public class RatingViewModel
    {
        public List<Restaurant> Restaurants;
        public SelectList Ratings;
        public string RestaurantRating { get; set; }
        public string SearchString { get; set; }
    }
}
