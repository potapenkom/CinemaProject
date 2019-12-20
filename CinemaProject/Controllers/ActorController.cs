using CinemaProject.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActor actors;

        public ActorController(IActor actors)
        {
            this.actors = actors;
        }

        public ViewResult ActorList()
        {
            var actor = actors.Actors;
            return View(actor);
        }
    }
}
