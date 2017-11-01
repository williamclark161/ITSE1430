﻿/* Class: ITSE-1430 C# Programming
 * Project: Lab 3 - Movie Library Window Database Version
 * Programmer: William Clark - Crestworld
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLib.Windows
{
    /// <summary> This form serves as the main that will call for 
    /// various functions that the Movie Detail Form will perform. 
    /// It also has an about page and exits the program. </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _gridMovies.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers

        private void OnFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnMovieAdd_Click(object sender, EventArgs e)
        {
            //_database.Add(null);

            var child = new MovieDetailForm("Movie Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            try
            {
                _database.Add(child.Movie);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(this, "Validation failed", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            };

            UpdateList();
        }

        private void OnMovieDelete_Click(object sender, EventArgs e)
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            try
            {
                DeleteMovie(movie);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void OnMovieEdit_Click(object sender, EventArgs e)
        {
            var movie = GetSelectedMovie();
            if (movie == null)
            {
                MessageBox.Show("No movies in library.");
                return;
            };

            EditMovie(movie);
        }

        private void OnHelpAbout_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }

        private void OnEditRow(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;

            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Movie;

            if (item != null)
                EditMovie(item);
        }

        private void OnKeyDownGrid(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var movie = GetSelectedMovie();
            if (movie != null)
                DeleteMovie(movie);

            //Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteMovie(Movie movie)
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{movie.Title}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //Delete product
            try
            {
                _database.Remove(movie.Id);
            }
            catch (Exception e)
            {
                DisplayError(e, "Delete Failed");
            };
            UpdateList();
        }

        private void DisplayError(Exception error, string title = "Error")
        {
            DisplayError(error.Message, title);
        }

        private void DisplayError(string message, string title = "Error")
        {
            MessageBox.Show(this, message, title ?? "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditMovie(Movie movie)
        {
            var child = new MovieDetailForm("Movie Details");
            child.Movie = movie;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //Save product
            try
            {
                _database.Update(child.Movie);
            }
            catch (Exception ex)
            {
                DisplayError(ex, "Update Failed");
            };
            UpdateList();
        }

        private Movie GetSelectedMovie()
        {
            // return _listMovies.SelectedItem as Movie;
            if (_gridMovies.SelectedRows.Count > 0)
            return _gridMovies.SelectedRows[0].DataBoundItem as Movie;

            return null;
        }

        private void UpdateList()
        {
            try
            {
                _bsMovies.DataSource = _database.GetAll().ToList();
            }
            catch (Exception e)
            {
                DisplayError(e, "Refresh Failed");
                _bsMovies.DataSource = null;
            };
        }

        //public delegate void ButtonClickCall(object sender, EventArgs e);

        //private void CallButton(ButtonClickCall functionToCall)
        //{
        //    functionToCall(this, EventArgs.Empty);
        //}

        //private Movie _movie;
        //private List<Movie> _movies = new List<Movie>();
        private IMovieDatebase _database = new MovieLib.Library.MemoryMovieDatabase();
        #endregion
    }
}
