﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Library
{
    /// <summary> Base class for product database </summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
        /// <summary>Adds a movie.</summary>          
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected override Movie AddCore(Movie movie)
        {
            var newMovie = CopyMovie(movie);
            _movie.Add(newMovie);

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

            return (movie != null) ? CopyMovie(movie) : null;
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {

            foreach (var movie in _movie)
                yield return CopyMovie(movie);
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        protected override void RemoveCore(int id)
        {
            var movie = FindMovie(id);
            if (movie != null)
                _movie.Remove(movie);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        protected override Movie UpdateCore(Movie existing, Movie movie)
        {
            //Replace 
            existing = FindMovie(movie.Id);
            _movie.Remove(existing);

            var newMovie = CopyMovie(movie);
            _movie.Add(newMovie);

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

        //Find a product by ID
        private Movie FindMovie(int id)
        {
            foreach (var movie in _movie)
            {
                if (movie.Id == id)
                    return movie;
            };

            return null;
        }

        private List<Movie> _movie = new List<Movie>();
        private int _nextId = 1;
    }
}
