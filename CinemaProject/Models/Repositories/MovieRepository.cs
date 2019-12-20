using CinemaProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Repositories
{
    public class MovieRepository : IMovie
    {
        private readonly AppDbContext appDbContext;

        public MovieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Movie> Movies => appDbContext.Movie;

        public Movie getMovie(int MovieId) => appDbContext.Movie.FirstOrDefault(p => p.Id == MovieId);
    }
}
