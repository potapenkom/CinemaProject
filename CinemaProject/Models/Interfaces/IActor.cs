using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Interfaces
{
    public interface IActor
    {
        IEnumerable<Actor> ActorMale { get; }
        IEnumerable<Actor> ActorFemale { get; }
        IEnumerable<Actor> Actors { get; }
        Actor getActor(int ActorId);
    }
}
