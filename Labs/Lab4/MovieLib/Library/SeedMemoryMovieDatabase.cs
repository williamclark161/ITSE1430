using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Library
{
    /// <summary> Base class for movie database </summary>
    public class SeedMemoryMovieDatabase : MemoryMovieDatabase
    {
        public SeedMemoryMovieDatabase()
        {
            AddCore(new Movie() { Id = 1, Title = "Pulp Fiction", Length = 154, IsOwned = true });
            AddCore(new Movie() { Id = 2, Title = "Wonder Woman", Length = 141, });
            AddCore(new Movie() { Id = 3, Title = "The Lion King", Length = 88, IsOwned = true });
            AddCore(new Movie() { Id = 4, Title = "Full Metal Jacket", Length = 116, IsOwned = true });
        }
    }
}
