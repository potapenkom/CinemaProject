﻿using CinemaProject.Models.Infrastructure;
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
            if (!content.Movie.Any())
                content.Movie.AddRange(Movies.Select(m => m.Value));

            if (!content.Actor.Any())
                content.AddRange(
                    new Actor { FirstName = "Daniel", LastName = "Radcliffe", Gender = Gender.Male, Age = 30 , Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] },
                    new Actor { FirstName = "Emma", LastName = "Watson", Gender = Gender.Female, Age = 29, Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] },
                    new Actor { FirstName = "Anthony", LastName = "McMillan", Gender = Gender.Male, Age = 69, Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] },
                    new Actor { FirstName = "Warwick", LastName = "Davis", Gender = Gender.Male, Age = 49, Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] },
                    new Actor { FirstName = "Helena", LastName = "Carter", Gender = Gender.Female, Age = 53, Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] },
                    new Actor { FirstName = "Javier", LastName = "Bardem", Gender = Gender.Male, Age = 50, Movie = Movies["Skyfall"] },
                    new Actor { FirstName = "Naomie", LastName = "Harris ", Gender = Gender.Female, Age = 43, Movie = Movies["Skyfall"] },
                    new Actor { FirstName = "Berenice", LastName = "Marlohe", Gender = Gender.Female, Age = 40, Movie = Movies["Skyfall"] },
                    new Actor { FirstName = "Judi", LastName = "Dench", Gender = Gender.Female, Age = 85, Movie = Movies["Skyfall"] },
                    new Actor { FirstName = " Daniel", LastName = "Craig", Gender = Gender.Male, Age = 51, Movie = Movies["Skyfall"] }
                    );
            if (!content.Director.Any())
                content.AddRange(
                    new Director { FirstName = "David", LastName = "Yates", BirthDate = new DateTime(1963, 11, 30), Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] },
                    new Director { FirstName = " Samuel ", LastName = "Mendes", BirthDate = new DateTime(1965, 8, 1), Movie = Movies["Skyfall"] }
                    );
            if (!content.Studio.Any())
                content.AddRange(
                    new Studio { Name = "Metro-Goldwyn-Mayer", Movie = Movies["Skyfall"] },
                    new Studio { Name = "Warner Bros", Movie = Movies["Harry Potter and the Deathly Hallows: Part 2"] }
                    );

            content.SaveChanges();
        }
        private static Dictionary<string, Movie> movies;
        public static Dictionary<string, Movie> Movies
        {
            get
            {
                if (movies == null)
                {
                    var list = new Movie[]
                    {
                        new Movie{ Name = "Harry Potter and the Deathly Hallows: Part 2", Genre = "Fantasy", Year = 2011},
                        new Movie{ Name = "Skyfall", Genre = " Action", Year = 2012}
                    };
                    movies = new Dictionary<string, Movie> { };
                    foreach (var el in list)
                    {
                        movies.Add(el.Name, el);
                    }
                }
                return movies;
            }
        }
    }
}

