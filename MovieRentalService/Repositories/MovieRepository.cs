using MovieRentalService.Models;
using System;
using System.Collections.Generic;
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
            return context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return context.Movies.Find(id);
        }
    }
}