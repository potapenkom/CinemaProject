using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Interfaces
{
    public interface IMovie
    {
        IEnumerable<Movie> Movies { get; }
        Movie getMovie(int MovieId);
       
    }
}
