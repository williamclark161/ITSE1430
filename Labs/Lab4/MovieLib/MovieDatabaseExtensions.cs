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
        /// <param name="name"></param>
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

        //public static IEnumerable<Movie> GetProductsByDiscountPrice(this IMovieDatabase source,
        //                                                               Func<Movie, decimal> priceCalculator)
        //{
        //    var products = from product in source.GetAll()
        //                   where product.IsDiscontinued
        //                   //select new SomeType () {
        //                   select new //Anonymous Type
        //                   {
        //                       Product = product,
        //                       AdjustedPrice = product.IsDiscontinued ? priceCalculator(product) : product.Price
        //                   };

        //    //Instead oa anonymous tyoe
        //    //var tuple = Tuple.Create<Product, decimal>(new Product(), 10M);

        //    return from product in products
        //           orderby product.AdjustedPrice
        //           select product.Product;

        //}

        public static void withSeedData(this IMovieDatabase sourse)
        {
            sourse.Add(new Movie() { Title = "Pulp Fiction", Length = 154, IsOwned = true });
            sourse.Add(new Movie() { Title = "Wonder Woman", Length = 141, });
            sourse.Add(new Movie() { Title = "The Lion King", Length = 88, IsOwned = true });
            sourse.Add(new Movie() { Title = "Full Metal Jacket", Length = 116, IsOwned = true });
        }
    }
}
