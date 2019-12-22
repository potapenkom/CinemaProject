using CinemaProject.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Repositories
{
    public class DirectorRepository : IDirector
    {
        private readonly AppDbContext appDbContext;

        public DirectorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Director> Directors => appDbContext.Director.Include(c => c.Movie);

        public Director getDirector(int DirectorId) => appDbContext.Director.FirstOrDefault(p => p.Id == DirectorId);
    }
}
