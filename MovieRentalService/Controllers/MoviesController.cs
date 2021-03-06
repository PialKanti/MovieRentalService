using MovieRentalService.Models;
using MovieRentalService.Repositories;
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
        private IMovieRepository movieRepository;

        public MoviesController()
        {
            this.movieRepository = new MovieRepository(new ApplicationDBContext());
        }

        public MoviesController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        // GET: Movies
        public ActionResult Index()
        {
            MoviesViewModel viewModel = new MoviesViewModel
            {
                Movies = movieRepository.GetMovies()
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            Movie movie = movieRepository.GetMovieById(id);

            if(movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        public ActionResult New()
        {
            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Genres = movieRepository.GetGenres()
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movieRepository.Add(movie);
                return RedirectToAction("Index", "Movies");
            }
            else
            {
                Movie existingMovie = movieRepository.Update(movie);
                return RedirectToAction("Details", "Movies", new { Id = existingMovie.Id });
            }
        }

        public ActionResult Edit(int id)
        {
            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Movie = movieRepository.GetMovieById(id),
                Genres = movieRepository.GetGenres()
            };
            return View("MovieForm", viewModel);
        }
    }
}