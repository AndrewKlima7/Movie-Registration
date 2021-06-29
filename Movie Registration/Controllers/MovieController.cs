using Microsoft.AspNetCore.Mvc;
using Movie_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Registration.Controllers 
{
    public class MovieController : Controller
    {
        MoviesContext db = new MoviesContext();

        public IActionResult MoviesIndex()
        {
            List<MovieList> movies = db.MovieLists.ToList();
            return View(movies);
        }
    }
}
