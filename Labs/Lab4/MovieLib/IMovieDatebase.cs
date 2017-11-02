using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    public interface IMovieDatebase
    {
        Movie Add(Movie movie);
        Movie Get(int id);
        IEnumerable<Movie> GetAll();
        void Remove(int id);
        Movie Update(Movie movie);
    }
}
