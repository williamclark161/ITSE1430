﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores
{
    /// <summary> Base class for product database </summary>
    public class SeedMemoryProductDatabase : MemoryProductDatabase
    {

        public SeedMemoryProductDatabase()
        {
            AddCore(new Product() { Id = 1, Name = "Galaxy S7", Price = 650 });
            AddCore(new Product() { Id = 2, Name = "Galaxy Note 7", Price = 150, IsDiscontinued = true });
            AddCore(new Product() { Id = 3, Name = "Windows Phone", Price = 100 });
            AddCore(new Product() { Id = 4, Name = "iPhone X", Price = 1900, IsDiscontinued = true });
        }
    }  
}
