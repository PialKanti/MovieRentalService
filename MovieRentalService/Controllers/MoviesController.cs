using MovieRentalService.Models;
using MovieRentalService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalService.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            MoviesViewModel viewModel = new MoviesViewModel
            {
                Movies = GetMovies()
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            Movie movie = GetMovies().FirstOrDefault(m => m.Id == id);
            return View(movie);
        }

        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id = 1, Name = "Shrek"},
                new Movie{Id = 2, Name = "Wall-e"}
            };
        }
    }
}