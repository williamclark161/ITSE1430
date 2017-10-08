/* Class: ITSE-1430 C# Programming
 * Project: Lab 2 - Movie Library Window Version
 * Programmer: William Clark - Crestworld
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    public class Movie
    {
        public Movie()
        {
            //Cross field initialization
        }

        private string _title;
        private string _description;

        /// <summary> Set the Movie Title. </summary>
        /// <value> Never Return NULL </value>
        public string Title
        {
            // string get_Name()
            get { return _title ?? ""; }
            // void set_Name (string value)
            set { _title = value?.Trim(); }

        }

        /// <summary> Set the discription. </summary>
        /// <value> Never Return NULL </value>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary> Gets or sets the length of the movie. </summary>
        public int Length { get; set; }

        /// <summary> Determines if Movie is Owned. </summary>
        public bool IsOwned { get; set; }

        public override string ToString()
        {
            return Title;
        }


        /// <summary>Validates the object.</summary>
        /// <returns>The error message or null.</returns>
        public virtual string Validate()
        {
            //Name cannot be empty
            if (String.IsNullOrEmpty(Title))
                return "Title cannot be empty.";

            //Price >= 0
            if (Length < 0)
                return "Legnth must be >= 0.";

            return null;
        }
    }
}
