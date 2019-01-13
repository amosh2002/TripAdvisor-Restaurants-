using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripAdvisor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TripAdvisorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TripAdvisorContext>>()))
            {
                // Look for any movies.
                if (context.Restaurant.Any())
                {
                    return;   // DB has been seeded
                }

                context.Restaurant.AddRange(
                    new Restaurant
                    {
                        Name = "Restaurant 1",
                        Location = "Location 1",
                        Cuisine = "Armenian, Italian",
                        Rating = 5
                    },

                    new Restaurant
                    {
                        Name = "Restaurant 2",
                        Location = "Location 2",
                        Cuisine = "Georgian",
                        Rating = 4
                    },

                    new Restaurant
                    {
                        Name = "Restaurant 3",
                        Location = "Location 3",
                        Cuisine = "Armenian, Russian",
                        Rating = 3
                    },

                    new Restaurant
                    {
                        Name = "Restaurant 4",
                        Location = "Location 4",
                        Cuisine = "Armenian, Caucasian",
                        Rating = 2
                    },
                    
                    new Restaurant
                    {
                        Name = "Restaurant 5",
                        Location = "Location 5",
                        Cuisine = "Italian, Armenian, French",
                        Rating = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
