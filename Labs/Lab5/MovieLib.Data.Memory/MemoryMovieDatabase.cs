/* Class: ITSE-1430 C# Programming
 * Project: Lab 5 - Movie Library Web Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data.Memory

{
    /// <summary>Provides an implementation of <see cref="IMovieDatabase"/> using a memory collection.</summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
        /// <summary>Adds a movie.</summary>          
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected override Movie AddCore(Movie movie)
        {
            var newMovie = CloneMovie(movie);
            newMovie.Id = _nextId++;
            _movies.Add(newMovie);

            return CloneMovie(newMovie);
        }

        /// <summary>Finds a movie by its title.</summary>
        /// <param name="title">The title to find.</param>
        /// <returns>The movie, if any.</returns>
        protected override Movie FindByTitleCore(string title)
        {
            return _movies.FirstOrDefault(movie => String.Compare(movie.Title, title, true) == 0);
        }
        
        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        protected override Movie GetCore(int id)
        {
            var movie = FindMovie(id);

            return CloneMovie(movie);
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {

            return from item in _movies
                   select CloneMovie(item);
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        protected override void RemoveCore(int id)
        {
            var existingMovie = FindMovie(id);
            if (existingMovie != null)
                _movies.Remove(existingMovie);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        protected override Movie UpdateCore(Movie movie)
        {
            //Replace 
            var existing = FindMovie(movie.Id);
            if (existing == null)
                throw new ArgumentException("Movie not found.", nameof(movie));

            CopyMovie(existing, movie);

            return CloneMovie(existing);
        }

        #region Private Members
        //Copies a movie to a new movie, including the ID
        private Movie CloneMovie(Movie source)
        {
            if (source == null)
                return null;

            var target = new Movie();

            CopyMovie(target, source);
            target.Id = source.Id;

            return target;
        }

        // Copies one movie to another
        private void CopyMovie(Movie existing, Movie source)
        {
            existing.Title = source.Title;
            existing.Description = source.Description;
            existing.IsOwned = source.IsOwned;
            existing.Length = source.Length;
        }

        //Find a movie by ID
        private Movie FindMovie(int id)
        {
            //return (from movie in _movies
            //        where movie.Id == id
            //        select movie).FirstOrDefault();

            return _movies.FirstOrDefault(movie => movie.Id == id);
        }

        private readonly List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;
        
        #endregion
    }
}
