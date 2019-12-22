using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Director> Directors { get; set; }
        public List<Studio> Studios { get; set; }
    }
}