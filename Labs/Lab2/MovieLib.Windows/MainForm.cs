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
    /// <summary> This form serves as the main that will call for various functions that the Movie Detail Form will perform. 
    /// It also has an about page and exits the program. </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate void ButtonClickCall(object sender, EventArgs e);

        private void CallButton(ButtonClickCall functionToCall)
        {
            functionToCall(this, EventArgs.Empty);
        }

        private Movie _movie;

        private void OnMovieAdd_Click(object sender, EventArgs e)
        {
            var child = new MovieDetailForm("Movie Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save movie
            _movie = child.Movie;
        }

        private void OnMovieEdit_Click(object sender, EventArgs e)
        {
            var child = new MovieDetailForm("Movie Details");
            child.Movie = _movie;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save product
            _movie = child.Movie;
        }

        private void OnMovieDelete_Click(object sender, EventArgs e)
        {
            if (_movie == null)
                return;

            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{_movie.Title}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Delete product
            _movie = null;
        }

        private void OnFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnHelpAbout_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }
    }
}
