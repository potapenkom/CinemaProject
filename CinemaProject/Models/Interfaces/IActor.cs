using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Interfaces
{
    public interface IActor
    {
        IEnumerable<Actor> Actors { get; }
        Actor getActor(int ActorId);
    }
}
