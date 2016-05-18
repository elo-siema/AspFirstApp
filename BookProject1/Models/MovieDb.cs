using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookProject1.Models
{
    public class MovieDb:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieReviews> MovieReviews { get; set; }
    }
}