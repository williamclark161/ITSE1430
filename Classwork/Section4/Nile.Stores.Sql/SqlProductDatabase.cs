using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    /// <summary> Provides an implementation of <see cref="IProductDatabase"/> using Sql Server </summary>
    public class SqlProductDatabase : ProductDatabase
    {
        #region Construction

        public SqlProductDatabase (string connectionString)
        {
            _connectionString = connectionString;

            
        }

        private readonly string _connectionString;
        #endregion

        protected override Product AddCore(Product product)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            var products = new List<Product>();
            using (var connection = OpenDatabase())
            {
                //command.CreatCommand();
                var cmd = new SqlCommand("GetAllProducts", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                

                using (var reader = cmd.ExecuteReader())  // returns a dbReader
                {
                    while (reader.Read()) // Efficiently Reads the database
                    {
                        //reader.GetName(0);
                        //reader.GetFieldType(1);
                        //Convert.ToInt32(reader["Id"]);
                        var product = new Product()
                        {
                            Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0), //Grabs the first column of type Int
                            Name = reader.GetFieldValue<string>(1), //Grabs the first column of type String
                            Price = reader.GetDecimal(2), //Grabs the fourth column of type Decimal
                            Description = reader.GetString(3), //Grabs the first column of type String
                            IsDiscontinued = reader.GetBoolean(4) //Grabs the fifth column of type Boolean
                        };
                        products.Add(product);
                    };
                };


                return products;
            };
        }

        protected override Product GetCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore(int id)
        {
            throw new NotImplementedException();
        }

        protected override Product UpdateCore(Product existing, Product newItem)
        {
            throw new NotImplementedException();
        }

        private SqlConnection OpenDatabase()
        {
            var connection = new SqlConnection(_connectionString);
            {
                connection.Open();

                return connection;
            };
        }
    }
}
