using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.MovieDatabases
{
    /// <summary>Provides an implementation of <see cref="IMovieDatabase"/> using a memory collection.</summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
        /// <summary>Adds a movie.</summary>          
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected override Movie AddCore(Movie movie)
        {
            var newMovie = CopyMovie(movie);

            foreach (var item in _movies)
            {
                if (item == newMovie)
                    throw new ArgumentException(nameof(newMovie), " is already in Movie Library Database");
            }

            _movies.Add(newMovie);

            if (newMovie.Id <= 0)
                newMovie.Id = _nextId++;
            else if (newMovie.Id >= _nextId)
                _nextId = newMovie.Id + 1;

            return CopyMovie(newMovie);
        }

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        protected override Movie GetCore(int id)
        {
            var movie = FindMovie(id);

            return (movie != null) ? CopyMovie(movie) : throw new Exception("Movie not in memory.");
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {

            return from item in _movies
                   select CopyMovie(item);

            //foreach (var movie in _movies)
            //    yield return CopyMovie(movie);
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        protected override void RemoveCore(int id)
        {
            var movie = FindMovie(id);
            if (movie != null)
                _movies.Remove(movie);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        protected override Movie UpdateCore(Movie existing, Movie movie)
        {
            //Replace 
            existing = FindMovie(movie.Id);
            _movies.Remove(existing);

            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            return CopyMovie(newMovie);
        }

        private Movie CopyMovie(Movie movie)
        {
            if (movie == null)
                return null;

            var newMovie = new Movie();
            newMovie.Id = movie.Id;
            newMovie.Title = movie.Title;
            newMovie.Description = movie.Description;
            newMovie.Length = movie.Length;
            newMovie.IsOwned = movie.IsOwned;

            return newMovie;
        }

        //Find a movie by ID
        private Movie FindMovie(int id)
        {
            return (from movie in _movies
                    where movie.Id == id
                    select movie).FirstOrDefault();

            //foreach (var movie in _movies)
            //{
            //    if (movie.Id == id)
            //        return movie;
            //};

            //return null;
        }

        private List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;
    }
}
