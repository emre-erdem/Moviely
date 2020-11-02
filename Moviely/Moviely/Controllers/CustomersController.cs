using Moviely.Models;
using Moviely.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviely.Models;
using Moviely.ViewModels;

namespace Moviely.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            { 
                new Customer { Name = "Ali", Id = 1},
                new Customer { Name = "Veli", Id = 2},
                new Customer { Name = "Ahmet", Id = 3},
                new Customer { Name = "Mehmet", Id = 4} 
            };
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
        public ActionResult Details(int? Id)
        {
            return Content("ID: "+Id.ToString());
        }
    }
}