using MovieRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalService.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int id);
        IEnumerable<Genre> GetGenres();
        Movie Add(Movie movie);
        Movie Update(Movie movie);
    }
}
