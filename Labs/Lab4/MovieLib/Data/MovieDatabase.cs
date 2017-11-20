/* Class: ITSE-1430 C# Programming
 * Project: Lab 4 - Movie Library Window Database SQL Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data
{
    /// <summary>Provides a base implementation of <see cref="IMovieDatabase"/>.</summary>
    public abstract class MovieDatabase : IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>          
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        public Movie Add(Movie movie)
        {
            // Validate Movie Is Null
            if (movie == null)
                throw new ArgumentNullException(nameof(movie), "Movie was null");

            // Validate Movie Using IValidatableObject
            ObjectValidator.Validate(movie);


            try
            {
                return AddCore(movie);
            }
            catch (Exception e)
            {
                //Throw different exception
                throw new Exception("Add failed", e);

                //Re-throw
                throw;
            }
        }

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        /// /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> must be greater than or equal to 0.</exception> 
        public Movie Get(int id)
        {
            // Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            return GetCore(id);
        }

        /// <summary>Gets all movies.</summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        public void Remove(int id)
        {
            // Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            RemoveCore(id);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        public Movie Update(Movie movie)
        {
            // Validate
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            // Using IValidatableObject
            ObjectValidator.Validate(movie);
            
            //Get existing movie
            var existing = GetCore(movie.Id) ?? throw new Exception("Movie not found.");
            //if (existing == null)
            //    return null;

            return UpdateCore(existing, movie);
        }

        #region Protected Members

        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected abstract Movie AddCore(Movie movie);

        /// <summary>Get a movie given its ID.</summary>
        /// <param name="id">The ID.</param>
        /// <returns>The movie, if any.</returns>
        protected abstract Movie GetCore(int id);

        protected abstract IEnumerable<Movie> GetAllCore();

        /// <summary>Removes a movie given its ID.</summary>
        /// <param name="id">The ID.</param>
        protected abstract void RemoveCore(int id);

        /// <summary>Updates a movie.</summary>
        /// <param name="existing">The existing movie.</param>
        /// <param name="newItem">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        protected abstract Movie UpdateCore(Movie existing, Movie newItem);

        
        #endregion
    }
}
