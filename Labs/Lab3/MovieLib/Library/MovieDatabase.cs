/* Class: ITSE-1430 C# Programming
 * Project: Lab 3 - Movie Library Window Database Version
 * Programmer: William Clark - Crestworld
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Library
{
    /// <summary> Base class for movie database </summary>
    public abstract class MovieDatabase : IMovieDatebase
    {
        /// <summary>Adds a movie.</summary>          
        /// <param name="movie">The product to add.</param>
        /// <returns>The added product.</returns>
        public Movie Add(Movie movie)
        {
            // Validate
            if (movie == null)
                return null;

            // Using IValidatableObject
            if (!ObjectValidator.TryValidate(movie, out var errors))
                return null;
            
            //Emulate database by storing copy
            return AddCore(movie);
        }

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        public Movie Get(int id)
        {
            // Validate
            if (id <= 0)
                return null;

            return GetCore(id);
        }

        protected abstract Movie GetCore(int id);

        /// <summary>Gets all movies.</summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        protected abstract IEnumerable<Movie> GetAllCore();

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        public void Remove(int id)
        {
            // Validate
            if (id <= 0)
                return;

            RemoveCore(id);
        }

        protected abstract void RemoveCore(int id);

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        public Movie Update(Movie movie)
        {
            // Validate
            if (movie == null)
                return null;

            // Using IValidatableObject
            if (!ObjectValidator.TryValidate(movie, out var errors))
                return null;
            
            //Get existing movie
            var existing = GetCore(movie.Id);
            if (existing == null)
                return null;

            return UpdateCore(existing, movie);
        }

        protected abstract Movie UpdateCore(Movie existing, Movie newItem);

        protected abstract Movie AddCore(Movie movie);
    }
}
