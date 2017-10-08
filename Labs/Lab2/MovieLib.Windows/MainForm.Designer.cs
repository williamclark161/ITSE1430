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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OnFileExit = new System.Windows.Forms.ToolStripTextBox();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnMovieAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.OnMovieEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.OnMovieDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.OnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnFileExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // OnFileExit
            // 
            this.OnFileExit.Name = "OnFileExit";
            this.OnFileExit.Size = new System.Drawing.Size(100, 23);
            this.OnFileExit.Text = "Exit";
            this.OnFileExit.Click += new System.EventHandler(this.OnFileExit_Click);
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
            this.OnHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.OnHelpAbout.Text = "About";
            this.OnHelpAbout.Click += new System.EventHandler(this.OnHelpAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Movie Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox OnFileExit;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnMovieAdd;
        private System.Windows.Forms.ToolStripMenuItem OnMovieEdit;
        private System.Windows.Forms.ToolStripMenuItem OnMovieDelete;
        private System.Windows.Forms.ToolStripMenuItem OnHelp;
        private System.Windows.Forms.ToolStripMenuItem OnHelpAbout;
    }
}

