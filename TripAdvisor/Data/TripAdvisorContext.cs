using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TripAdvisor.Models
{
    public class TripAdvisorContext : DbContext
    {
        public TripAdvisorContext (DbContextOptions<TripAdvisorContext> options)
            : base(options)
        {
        }

        public DbSet<TripAdvisor.Models.Restaurant> Restaurant { get; set; }
    }
}
