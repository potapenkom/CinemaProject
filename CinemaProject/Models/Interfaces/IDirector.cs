using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Interfaces
{
    public interface IDirector
    {
        IEnumerable<Director> Directors { get; }
        Director getDirector(int DirectorId);
    }
}
