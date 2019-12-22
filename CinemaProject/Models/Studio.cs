using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
