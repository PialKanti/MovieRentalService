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
            return context.Movies.Include(c => c.Genre).SingleOrDefault(m => m.Id == id);
        }

        public IEnumerable<Genre> GetGenres()
        {
            return context.Genres.ToList();
        }

        public Movie Add(Movie movie)
        {
            movie.DateAdded = DateTime.Now;
            Movie newMovie = context.Movies.Add(movie);
            context.SaveChanges();
            return newMovie;
        }

        public Movie Update(Movie movie)
        {
            Movie movieInDB = context.Movies.Single(m => m.Id == movie.Id);
            movieInDB.Name = movie.Name;            
            movieInDB.GenreId = movie.GenreId;            
            movieInDB.ReleaseDate = movie.ReleaseDate;            
            movieInDB.NumberInStock = movie.NumberInStock;

            context.SaveChanges();
            return movieInDB;
        }
    }
}