using MovieRentalService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieRentalService.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private ApplicationDBContext context;

        public MovieRepository(ApplicationDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return context.Movies.Include(c => c.Genre).ToList();
        }

        public Movie GetMovieById(int id)
        {
            return context.Movies.Find(id);
        }
    }
}