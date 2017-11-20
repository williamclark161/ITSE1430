/* Class: ITSE-1430 C# Programming
 * Project: Lab 4 - Movie Library Window Database SQL Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Represents a movie </summary>
    /// <remarks> This will represent a movie with other stuff. </remarks>
    public class Movie : IValidatableObject
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }


        /// <summary> Gets or sets the movie title. </summary>
        /// <value> Never Return NULL </value>
        public string Title
        {
            get => _title ?? "";
            set => _title = value?.Trim();

        }

        /// <summary> Gets or sets the movie discription. </summary>
        /// <value> Never Return NULL </value>
        public string Description
        {
            get => _description ?? "";
            set => _description = value?.Trim();
        }

        /// <summary> Gets or sets the length of the movie. </summary>
        public int Length { get; set; }

        /// <summary> Determines if Movie is Owned. </summary>
        public bool IsOwned { get; set; }

        /// <summary>Validates the object.</summary>
        /// <returns>The error message or null.</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Title cannot be empty
            if (String.IsNullOrEmpty(Title))
                yield return new ValidationResult("Title cannot be empty.", new[] { nameof(Title) });

            // Length >= 0
            if (Length < 0)
                yield return new ValidationResult("Length must be >= 0.", new[] { nameof(Length) });
        }

        #region Private Members

        private string _title;
        private string _description;
        #endregion
    }
}
