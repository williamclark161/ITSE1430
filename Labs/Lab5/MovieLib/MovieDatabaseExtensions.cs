/* Class: ITSE-1430 C# Programming
 * Project: Lab 5 - Movie Library Web Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary> Provides extensions for <see cref="IMovieDatabase"/>. </summary>
    public static class MovieDatabaseExtensions
    {
        /// <summary> Get a product by name. /// </summary>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <returns>The product, if found.</returns>
        public static Movie GetByTitle(this IMovieDatabase source, string title)
        {
            foreach (var item in source.GetAll())
            {
                if (String.Compare(item.Title, title, true) == 0)
                    return item;
            };

            return null;
        }

        /// <summary>Adds seed data to a database.</summary>
        /// <param name="source">The data to seed.</param>
        public static void WithSeedData(this IMovieDatabase source)
        {
            source.Add(new Movie() { Title = "Pulp Fiction", Length = 154, IsOwned = true });
            source.Add(new Movie() { Title = "Wonder Woman", Length = 141, });
            source.Add(new Movie() { Title = "The Lion King", Length = 88, IsOwned = true });
            source.Add(new Movie() { Title = "Full Metal Jacket", Length = 116, IsOwned = true });
        }
    }
}
