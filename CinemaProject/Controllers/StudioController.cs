using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaProject.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaProject.Controllers
{
    public class StudioController : Controller
    {
        private readonly IStudio studios;

        public StudioController(IStudio studios)
        {
            this.studios = studios;
        }

        public IActionResult StudioList()
        {
            var studio = studios.Studios;
            return View(studio);
        }
    }
}