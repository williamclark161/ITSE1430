﻿/* Class: ITSE-1430 C# Programming
 * Project: Lab 4 - Movie Library Window Database SQL Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Provides a database of <see cref="Movie"/> items.</summary>
    public interface IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        Movie Add(Movie movie);

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> must be greater than or equal to 0.</exception> 
        Movie Get(int id);

        /// <summary>Gets all movie.</summary>
        /// <returns>The movie.</returns>
        IEnumerable<Movie> GetAll();

        /// <summary>Removes the movie.</summary>
        /// <param name="id">The movie to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> must be greater than or equal to 0.</exception>
        void Remove(int id);

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        /// <exception cref="Exception">Movie not found.</exception>
        Movie Update(Movie movie);
    }
}
