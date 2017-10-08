/* Class: ITSE-1430 C# Programming
 * Project: Lab 2 - Movie Library Window Version
 * Programmer: William Clark - Crestworld
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
    /// It will add, edit and delete a movie from the library.  Everything else is handeled by the main form. </summary>
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

        public MovieDetailForm(string title, Movie movie) : this(title)
        {
            Movie = movie;
        }
        #endregion

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

        /// <summary> Gets or sets the movie being shown. </summary>
        public Movie Movie { get; set; }

        /// <summary> Will lock the four features of the movie entered by the user </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            var movie = new Movie();
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;

            movie.Length = GetLength(_txtLength);
            movie.IsOwned = _chkOwned.Checked;

            //Add validation
            var error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                //Show the error
                ShowError(error, "Validation Error");
                return;
            };

            Movie = movie;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary> Will stop what ever function that was called by the main form </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowError(string message, string title)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetLength(TextBox conrtol)
        {
            if (int.TryParse(_txtLength.Text, out int length))
                return length;

            //Validate price            
            return -1;
        }

        /// <summary> Simply will close the Movie Detail Form </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = sender as Form;

            //casting for value types
            if (sender is int)
            {
                var intValue2 = (int)sender;
            };

            //Pattern matching
            if (sender is int intValue)
            {

            };

            if (MessageBox.Show(this, "Are you sure?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void ProductDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        /// <summary> Will validate the title of the movie. </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatingTitle(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (String.IsNullOrEmpty(tb.Text))
            {
                _errors.SetError(tb, "Title Is Required");
            }
            else
                _errors.SetError(tb, "");
        }
    }
}
