using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mission4.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Drama/Romance",
                    Title = "Good Will Hunting",
                    Year = 1997,
                    Director = "Gus Van Sant",
                    Rating = "R",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "N/A",
                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Drama/Crime",
                    Title = "Catch Me If You Can",
                    Year = 2002,
                    Director = "Steven Spielberg",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "N/A",
                    Notes = "N/A",
                },

                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Drama",
                    Title = "The Pursuit of Happyness",
                    Year = 2006,
                    Director = "Grabriele Muccino",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Jonah",
                    Notes = "Feel Good Movie",
                }


            );
        }
    }
}
