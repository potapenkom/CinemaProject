using CinemaProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models.Repositories
{
    public class StudioRepository : IStudio
    {
        private readonly AppDbContext appDbContext;

        public StudioRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Studio> Studios => appDbContext.Studio;

        public Studio getStudio(int StudioId) => appDbContext.Studio.FirstOrDefault(p => p.Id == StudioId);

    }
}
