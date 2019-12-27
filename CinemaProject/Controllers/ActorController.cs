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

        public ViewResult MaleList()
        {
            var actor = actors.ActorMale;
             return View(actor);
        }

        public ViewResult FemaleList()
        {
            var actor = actors.ActorFemale;
            return View(actor);
        }


        public ViewResult ActorList()
        {
            var actor = actors.Actors;
            return View(actor);
        }
    }
}
