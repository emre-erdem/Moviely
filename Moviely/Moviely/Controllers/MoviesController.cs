using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviely.Models;
using Moviely.ViewModels;

namespace Moviely.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie> 
            {
                new Movie { Name = "LOTR!", Id = 1 },
                new Movie { Name = "shrek", Id = 2 },
                new Movie { Name = "lala!", Id = 3 },
                new Movie { Name = "dortdort!", Id = 4 }
            };

            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        } 

        /*
        // Movies
        public ActionResult Index(int? pageIndex, string sortBy) // ? means nullable
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */

    }
}