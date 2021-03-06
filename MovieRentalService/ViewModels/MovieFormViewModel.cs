using MovieRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalService.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}