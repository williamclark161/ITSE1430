using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.MovieDatabases.Sql
{
    public class SqlMovieDatabase : IMovieDatabase
    {
        #region Construction

        public SqlProductDatabase(string connectionString)
        {
            _connectionString = connectionString;


        }

        private readonly string _connectionString;
        #endregion

        protected override Movie AddCore(Movie movie)
        {
            var id = 0;
            using (var connection = OpenDatabase())
            {
                var cmd = new SqlCommand("AddProduct", connection)
                { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = product.Name;
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                id = Convert.ToInt32(cmd.ExecuteScalar());
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
