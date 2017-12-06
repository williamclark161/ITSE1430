/* Class: ITSE-1430 C# Programming
 * Project: Lab 4 - Movie Library Window Database SQL Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */
 
 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data.Sql
{
    /// <summary> Provides an implementation of <see cref="IMovieDatabase"/> using Sql Server </summary>
    public class SqlMovieDatabase : MovieDatabase
    {
        #region Construction

        public SqlMovieDatabase (string connectionString)
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
                var cmd = new SqlCommand("AddMovie", connection)
                { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@title", SqlDbType.VarChar).Value = movie.Title;
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@isOwned", movie.IsOwned);

                id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return GetCore(id);
        }

        protected override Movie FindByTitleCore(string title)
        {
            //Not supported directly
            var movies = GetAllCore();

            return movies.FirstOrDefault(m => String.Compare(m.Title, title, true) == 0);
        }

        protected override Movie GetCore(int id)
        {
            using (var connection = OpenDatabase())
            {
                var cmd = new SqlCommand("GetMovie", connection)
                { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@id", id);

                //Using a dataset instead of a reader
                var dataSet = new DataSet();
                var dataAdapter = new SqlDataAdapter()
                {
                    SelectCommand = cmd
                };

                dataAdapter.Fill(dataSet);

                var table = dataSet.Tables.OfType<DataTable>().FirstOrDefault();
                if (table != null)
                {
                    var row = table.AsEnumerable().FirstOrDefault();
                    if (row != null)
                    {
                        return new Movie()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Title = row.Field<string>("Title"),
                            Description = row.Field<string>("Description"),
                            Length = row.Field<Int32>("Length"),
                            IsOwned = row.Field<bool>("IsOwned")
                        };
                    };
                };
            };

            return null;
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            var movies = new List<Movie>();
            using (var connection = OpenDatabase())
            {
                //command.CreatCommand();
                var cmd = new SqlCommand("GetAllMovies", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                using (var reader = cmd.ExecuteReader())  // returns a dbReader
                {
                    while (reader.Read()) // Efficiently Reads the database
                    {
                        var movie = new Movie()
                        {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0), //Grabs the first column of type Int
                            Title = reader.GetFieldValue<string>(1), //Grabs the second column of type String
                            Length = reader.GetInt32(2), //Grabs the fourth column of type Int
                            Description = reader.GetString(3), //Grabs the third column of type String
                            IsOwned = reader.GetBoolean(4) //Grabs the fifth column of type Boolean
                        };
                        movies.Add(movie);
                    };
                };


                return movies;
            };
        }

        

        protected override void RemoveCore(int id)
        {
            using (var connection = OpenDatabase())
            {
                //Alternative approach to creating command
                var cmd = connection.CreateCommand();
                cmd.CommandText = "RemoveMovie";
                cmd.CommandType = CommandType.StoredProcedure;

                var paramenter = new SqlParameter("@id", id);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            };
        }

        protected override Movie UpdateCore(Movie movie)
        {
            using (var connection = OpenDatabase())
            {
                var cmd = new SqlCommand("UpdateMovie", connection)
                { CommandType = CommandType.StoredProcedure };

                cmd.Parameters.AddWithValue("@id", movie.Id);
                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@isOwned", movie.IsOwned);

                cmd.ExecuteNonQuery();
            };

            return movie;
        }

        private SqlConnection OpenDatabase()
        {
            var connection = new SqlConnection(_connectionString);
            
            connection.Open();

            return connection;
            
        }
    }
}
