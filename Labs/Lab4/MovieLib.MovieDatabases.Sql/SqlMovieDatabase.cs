using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.MovieDatabases.Sql
{
    public class SqlMovieDatabase : MovieDatabase
    {
        protected override Movie AddCore(Movie movie)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override Movie GetCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override Movie UpdateCore(Movie existing, Movie newItem)
        {
            throw new NotImplementedException();
        }
    }
}
