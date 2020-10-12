using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Data
{
    public class MovieContext :DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
