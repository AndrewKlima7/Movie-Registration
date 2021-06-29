using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movie_Registration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Registration.Controllers
{
    public class HomeController : Controller
    {
        MoviesContext db = new MoviesContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Result(MovieList m)
        {
            //this is where you would add the movie to the database if using SQL

            db.MovieLists.Add(m);
            db.SaveChanges();
            return View(m);
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
