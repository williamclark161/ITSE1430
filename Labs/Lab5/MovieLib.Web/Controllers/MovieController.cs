using MovieLib.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieLib.Web.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var model = new List<MovieViewModel>() {
                new MovieViewModel() { Id = 1, Title = "Movie A", Length = 123 }
            };
            return View(model);
        }
    }
}