using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaProject.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaProject.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IDirector directors;

        public DirectorController(IDirector directors)
        {
            this.directors = directors;
        }

        public IActionResult DirectorList()
        {
            var director = directors.Directors;
            return View(director);
        }
    }
}