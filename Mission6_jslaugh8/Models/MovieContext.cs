using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jslaugh8.Models
{
    public class MovieContext : DbContext
    {

        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {

        }

        // Declaring which model we are working with
        public DbSet<FormResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    MovieId = 1,
                    Category = "Romance/Drama",
                    Title = "The Great Gatsby",
                    Year = 2013,
                    Director = "Baz Luhrmann",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",

                },
                new FormResponse
                {
                    MovieId = 2,
                    Category = "Family/Drama",
                    Title = "A Dog's Purpose",
                    Year = 2017,
                    Director = "Lasse Hallström",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new FormResponse
                {
                    MovieId = 3,
                    Category = "Sci-fi/Action",
                    Title = "John Carter",
                    Year = 2012,
                    Director = "Andrew Stanton",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "",
                    Notes = "",
                }
                );
        }


    }
}
