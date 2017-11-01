﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores
{
    /// <summary>Provides a <see cref="MemoryProductDatabase"/> with products already added.</summary>
    public static class ProductDatabaseExtensions
    {

        /// <summary>Initializes an instance of the <see cref="SeedMemoryProductDatabase"/> class.</summary>
        public static void WithSeedData(IProductDatabase database)
        {
            database.Add(new Product() { Name = "Galaxy S7", Price = 650 });
            database.Add(new Product() { Name = "Galaxy Note 7", Price = 150, IsDiscontinued = true });
            database.Add(new Product() { Name = "Windows Phone", Price = 100 });
            database.Add(new Product() { Name = "iPhone X", Price = 1900, IsDiscontinued = true });
        }
    }  
}
