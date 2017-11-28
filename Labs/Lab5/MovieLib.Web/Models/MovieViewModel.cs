using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLib.Web.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Length { get; set; }

        public bool IsOwned { get; set; }
    }
}