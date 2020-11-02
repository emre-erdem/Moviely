using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Moviely.Models;

namespace Moviely.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Custormers { get; set; }
    }
}