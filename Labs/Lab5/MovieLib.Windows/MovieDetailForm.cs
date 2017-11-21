/* Class: ITSE-1430 C# Programming
 * Project: Lab 4 - Movie Library Window Database SQL Version
 * Programmer: William Clark - CocoaVision/Crestworld
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLib.Windows
{
    /// <summary> This form performs the main function called upon by the main form.  
    /// It will add, edit and delete a movie from the library.  
    /// Everything else is handeled by the main form. </summary>
    public partial class MovieDetailForm : Form
    {
        #region Construction

        public MovieDetailForm()
        {
            InitializeComponent();
        }

        public MovieDetailForm(string title) : this()
        {
            Text = title;
        }

        #endregion

        /// <summary>Gets or sets the movie being shown.</summary>
        public Movie Movie { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Length.ToString();
                _chkOwned.Checked = Movie.IsOwned;
            };

            ValidateChildren();
        }

        #region Event Handlers
        /// <summary> Will stop what ever function that was called by the main form </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary> Will lock the four features of the movie entered by the user </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            };

            //Create a new movie
            var movie = new Movie()
            {
                Id = Movie?.Id ?? 0,
                Title = _txtTitle.Text,
                Description = _txtDescription.Text,
                Length = GetLength(_txtLength),
                IsOwned = _chkOwned.Checked,
            };

            if (!ObjectValidator.TryValidate(movie, out var errors))
            {
                //Show the error
                ShowError("Not Valid", "Validation Error");
                return;
            };

            Movie = movie;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary> Will validate the title of the movie. </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatingTitle(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (String.IsNullOrEmpty(tb.Text))
                _errors.SetError(tb, "Title Is Required");
            else
                _errors.SetError(tb, "");
        }

        /// <summary> Will validate the movie length.  That it is >= 0. </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatingLength(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (GetLength(tb) < 0)
            {
                e.Cancel = true;
                _errors.SetError(_txtLength, "Length must be >= 0");
            }
            else
                _errors.SetError(_txtLength, "");
        }
        #endregion

        private int GetLength(TextBox conrtol)
        {
            if (int.TryParse(_txtLength.Text, out int length))
                return length;

            //Validate length
            return -1;
        }

        private void ShowError(string message, string title)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
