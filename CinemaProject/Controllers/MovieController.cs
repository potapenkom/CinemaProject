using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaProject.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaProject.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovie movies;

        public MovieController(IMovie movies)
        {
            this.movies = movies;
        }
        public IActionResult MovieList()
        {
            var movie = movies.Movies;
            return View(movie);
        }
    }
}