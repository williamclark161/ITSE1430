using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    public interface IMovieDatebase
    {
        /// <exception cref="ArgumentNullException">Product is null</exception>
        /// <exception cref="ValidationException">Product is invalid</exception>
        Movie Add(Movie movie);

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        Movie Get(int id);

        /// <summary>Gets all movies.</summary>
        /// <returns>The movies.</returns>
        IEnumerable<Movie> GetAll();

        /// <summary>Removes the movie.</summary>
        /// <param name="id">The movie to remove.</param>
        void Remove(int id);

        /// <summary>Updates a movie.</summary>
        /// <param name="product">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        Movie Update(Movie movie);
    }
}
