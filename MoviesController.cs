using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moviely.Models;

namespace Moviely.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "LOTR!", Id = 1234 };

            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        // Movies
        public ActionResult Index(int? pageIndex, string sortBy) // ? means nullable
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}
