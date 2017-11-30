using MovieLib.Data.Sql;
using MovieLib.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieLib.Web.Controllers
{
    public class MovieController : Controller
    {
        public MovieController() : this(GetDatabase())
        {
        }
        public MovieController(IMovieDatabase database)
        {
            _database = database;
        }

        public ActionResult Add()
        {
            var model = new MovieViewModel();

            return View(model);
        }

        //public ActionResult Add(MovieViewModel model)
        //{

        //}

        public ActionResult Edit(int id)
        {
            var movie = _database.Get(id);

            return View(movie.ToModel());
        }

        public ActionResult Delete(int id)
        {
            var movie = _database.Get(id);

            return View(movie.ToModel());
        }

        // GET: Movie
        public ActionResult List()
        {
            var movies = _database.GetAll();

            return View(movies.ToModel());
        }

        private static IMovieDatabase GetDatabase()
        {
            var connstring = ConfigurationManager.ConnectionStrings["ProductDatabase"];

            return new SqlMovieDatabase(connstring.ConnectionString);
        }

        private readonly IMovieDatabase _database;
    }
}