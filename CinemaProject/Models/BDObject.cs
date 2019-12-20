using CinemaProject.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models
{
    public class BDObject
    {
        public static void Initial(AppDbContext content)
        {
            if (!content.Actor.Any())
                content.AddRange(
                    new Actor { FirstName = "Daniel", LastName = "Radcliffe", Gender = Gender.Male, Age = 30 },
                    new Actor { FirstName = " Daniel", LastName = "Craig", Gender = Gender.Male, Age = 51 }
                    );
            if (!content.Director.Any())
                content.AddRange(
                    new Director { FirstName = "David", LastName = "Yates", BirthDate = new DateTime(1963, 11, 30)},
                    new Director { FirstName = " Samuel ", LastName = "Mendes", BirthDate = new DateTime(1965, 8, 1) }
                    );
            if (!content.Studio.Any())
                content.AddRange(
                    new Studio { Name = "Metro-Goldwyn-Mayer" },
                    new Studio { Name = "Warner Bros" }
                    );

            if (!content.Movie.Any())
                content.AddRange(
                     new Movie { Name = "Skyfall", Genre = " Action", Year = 2012 },
                     new Movie { Name = "Harry Potter and the Deathly Hallows: Part 2", Genre = "Fantasy", Year = 2011 }
                    );
            content.SaveChanges();
        }           
    }
}

