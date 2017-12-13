/* Class: ITSE-1430 C# Programming
 * Project: Lab 5 - Movie Library Web Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLib.Web.Models
{
    public static class MovieExtentions
    {
        public static IEnumerable<MovieViewModel> ToModel(this IEnumerable<Movie> source)
        {
            return from item in source
                   orderby item.Title ascending
                   select item.ToModel();
        }

        public static MovieViewModel ToModel(this Movie movie)
        {
            return new MovieViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Length = movie.Length,
                IsOwned = movie.IsOwned
            };
        }

        public static Movie ToDomain(this MovieViewModel source)
        {
            return new Movie()
            {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                Length = source.Length,
                IsOwned = source.IsOwned
            };
        }
    }
}