using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Interfaces
{
    public interface IStudio
    {
        IEnumerable<Studio> Studios { get; }
        Studio getStudio(int StudioId);
    }
}
