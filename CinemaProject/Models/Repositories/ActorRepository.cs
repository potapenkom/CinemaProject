using CinemaProject.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Repositories
{
    public class ActorRepository : IActor
    {
        private readonly AppDbContext appDbContext;

        public ActorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Actor> Actors => appDbContext.Actor.Include(c => c.Movie);

        public Actor getActor(int ActorId) => appDbContext.Actor.FirstOrDefault(p => p.Id == ActorId);
    }
}
