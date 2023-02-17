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

        // Setting up the Movies Database
        public DbSet<Movie> Movies { get; set; }
        //Creating of the Category Database
        public DbSet<MovieCategory> Category { get; set; }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Seed Data for Categories
            mb.Entity<MovieCategory>().HasData(
                new MovieCategory
                {
                    CategoryId = 1,
                    CategoryName = "Romance/Drama",
                },
                new MovieCategory
                {
                    CategoryId = 2,
                    CategoryName = "Family/Drama",
                },
                new MovieCategory
                {
                    CategoryId = 3,
                    CategoryName = "Sci-fi/Action",
                }
                );
            //Seed data for Movies
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Great Gatsby",
                    Year = 2013,
                    Director = "Baz Luhrmann",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",

                },
                new Movie
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "A Dog's Purpose",
                    Year = 2017,
                    Director = "Lasse Hallström",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new Movie
                {
                    MovieId = 3,
                    CategoryId = 3,
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
