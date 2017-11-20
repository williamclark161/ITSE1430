namespace MovieLib.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripTextBox();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnMovieAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.OnMovieEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.OnMovieDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.OnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._gridMovies = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOwnedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._bsMovies = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.moviesToolStripMenuItem,
            this.OnHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(100, 23);
            this._miFileExit.Text = "Exit";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnMovieAdd,
            this.OnMovieEdit,
            this.OnMovieDelete});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // OnMovieAdd
            // 
            this.OnMovieAdd.Name = "OnMovieAdd";
            this.OnMovieAdd.Size = new System.Drawing.Size(107, 22);
            this.OnMovieAdd.Text = "Add";
            this.OnMovieAdd.Click += new System.EventHandler(this.OnMovieAdd_Click);
            // 
            // OnMovieEdit
            // 
            this.OnMovieEdit.Name = "OnMovieEdit";
            this.OnMovieEdit.Size = new System.Drawing.Size(107, 22);
            this.OnMovieEdit.Text = "Edit";
            this.OnMovieEdit.Click += new System.EventHandler(this.OnMovieEdit_Click);
            // 
            // OnMovieDelete
            // 
            this.OnMovieDelete.Name = "OnMovieDelete";
            this.OnMovieDelete.Size = new System.Drawing.Size(107, 22);
            this.OnMovieDelete.Text = "Delete";
            this.OnMovieDelete.Click += new System.EventHandler(this.OnMovieDelete_Click);
            // 
            // OnHelp
            // 
            this.OnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnHelpAbout});
            this.OnHelp.Name = "OnHelp";
            this.OnHelp.Size = new System.Drawing.Size(44, 20);
            this.OnHelp.Text = "Help";
            // 
            // OnHelpAbout
            // 
            this.OnHelpAbout.Name = "OnHelpAbout";
            this.OnHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.OnHelpAbout.Text = "About";
            this.OnHelpAbout.Click += new System.EventHandler(this.OnHelpAbout_Click);
            // 
            // _gridMovies
            // 
            this._gridMovies.AllowUserToAddRows = false;
            this._gridMovies.AllowUserToDeleteRows = false;
            this._gridMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this._gridMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._gridMovies.AutoGenerateColumns = false;
            this._gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ID,
            this.descriptionDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.isOwnedDataGridViewCheckBoxColumn});
            this._gridMovies.DataSource = this._bsMovies;
            this._gridMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridMovies.Location = new System.Drawing.Point(0, 24);
            this._gridMovies.Name = "_gridMovies";
            this._gridMovies.ReadOnly = true;
            this._gridMovies.RowHeadersVisible = false;
            this._gridMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridMovies.Size = new System.Drawing.Size(690, 339);
            this._gridMovies.TabIndex = 1;
            this._gridMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEditRow);
            this._gridMovies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownGrid);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 300F;
            this.titleDataGridViewTextBoxColumn.Frozen = true;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 300F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isOwnedDataGridViewCheckBoxColumn
            // 
            this.isOwnedDataGridViewCheckBoxColumn.DataPropertyName = "IsOwned";
            this.isOwnedDataGridViewCheckBoxColumn.HeaderText = "IsOwned";
            this.isOwnedDataGridViewCheckBoxColumn.Name = "isOwnedDataGridViewCheckBoxColumn";
            this.isOwnedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // _bsMovies
            // 
            this._bsMovies.DataSource = typeof(MovieLib.Movie);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 363);
            this.Controls.Add(this._gridMovies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Movie Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnMovieAdd;
        private System.Windows.Forms.ToolStripMenuItem OnMovieEdit;
        private System.Windows.Forms.ToolStripMenuItem OnMovieDelete;
        private System.Windows.Forms.ToolStripMenuItem OnHelp;
        private System.Windows.Forms.ToolStripMenuItem OnHelpAbout;
        private System.Windows.Forms.BindingSource _bsMovies;
        private System.Windows.Forms.DataGridView _gridMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOwnedDataGridViewCheckBoxColumn;
    }
}

