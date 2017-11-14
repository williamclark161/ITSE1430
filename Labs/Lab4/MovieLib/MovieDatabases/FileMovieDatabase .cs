using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Library
{
    /// <summary> Base class for product database </summary>
    public class FileMovieDatabase : MemoryMovieDatabase
    {
        public FileMovieDatabase(string filename)
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));

            if (String.IsNullOrEmpty(filename))
                throw new ArgumentException("Filename cannor be empty.", nameof(filename));

            _filename = filename;

            LoadFile(filename);
        }

        /// <summary>Adds a movie.</summary>          
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected override Movie AddCore(Movie movie)
        {
            var newMovie = base.AddCore(movie);

            SaveFile(_filename);

            return newMovie;
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        protected override void RemoveCore(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        protected override Movie UpdateCore(Movie existing, Movie movie)
        {
            throw new NotImplementedException();
        }

        private void LoadFile(string filename)
        {
            if (!File.Exists(filename))
                return;

            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line))
                    continue;

                var fields = line.Split(',');
                var movie = new Movie()
                {
                    Id = Int32.Parse(fields[0]),
                    Title = fields[1],
                    Description = fields[2],
                    Length = Int32.Parse(fields[3]),
                    IsOwned = Boolean.Parse(fields[4]),
                };

                base.AddCore(movie);
            };
        }

        private void SaveFile(string filename)
        {
            //Streaming

        }

        private readonly string _filename;
    }
}
