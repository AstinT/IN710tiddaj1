namespace BestMovieDatabase
{
    partial class Form1
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.lblAddMovieYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDeleteMovieYear = new System.Windows.Forms.Label();
            this.lblSearchYear = new System.Windows.Forms.Label();
            this.tbAddMovieYear = new System.Windows.Forms.TextBox();
            this.tbAddMovieTitle = new System.Windows.Forms.TextBox();
            this.tbAddDirector = new System.Windows.Forms.TextBox();
            this.tbDeleteMovieYear = new System.Windows.Forms.TextBox();
            this.tbSearchYear = new System.Windows.Forms.TextBox();
            this.rtDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(39, 65);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(150, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(39, 259);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteMovie.TabIndex = 1;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(39, 392);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(39, 465);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(150, 23);
            this.btnPrintAll.TabIndex = 3;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // lblAddMovieYear
            // 
            this.lblAddMovieYear.AutoSize = true;
            this.lblAddMovieYear.Location = new System.Drawing.Point(236, 65);
            this.lblAddMovieYear.Name = "lblAddMovieYear";
            this.lblAddMovieYear.Size = new System.Drawing.Size(29, 13);
            this.lblAddMovieYear.TabIndex = 5;
            this.lblAddMovieYear.Text = "Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(236, 101);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(236, 139);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "Director";
            // 
            // lblDeleteMovieYear
            // 
            this.lblDeleteMovieYear.AutoSize = true;
            this.lblDeleteMovieYear.Location = new System.Drawing.Point(236, 259);
            this.lblDeleteMovieYear.Name = "lblDeleteMovieYear";
            this.lblDeleteMovieYear.Size = new System.Drawing.Size(29, 13);
            this.lblDeleteMovieYear.TabIndex = 8;
            this.lblDeleteMovieYear.Text = "Year";
            // 
            // lblSearchYear
            // 
            this.lblSearchYear.AutoSize = true;
            this.lblSearchYear.Location = new System.Drawing.Point(236, 392);
            this.lblSearchYear.Name = "lblSearchYear";
            this.lblSearchYear.Size = new System.Drawing.Size(29, 13);
            this.lblSearchYear.TabIndex = 9;
            this.lblSearchYear.Text = "Year";
            // 
            // tbAddMovieYear
            // 
            this.tbAddMovieYear.Location = new System.Drawing.Point(312, 57);
            this.tbAddMovieYear.Name = "tbAddMovieYear";
            this.tbAddMovieYear.Size = new System.Drawing.Size(465, 20);
            this.tbAddMovieYear.TabIndex = 10;
            // 
            // tbAddMovieTitle
            // 
            this.tbAddMovieTitle.Location = new System.Drawing.Point(312, 101);
            this.tbAddMovieTitle.Name = "tbAddMovieTitle";
            this.tbAddMovieTitle.Size = new System.Drawing.Size(465, 20);
            this.tbAddMovieTitle.TabIndex = 11;
            // 
            // tbAddDirector
            // 
            this.tbAddDirector.Location = new System.Drawing.Point(312, 139);
            this.tbAddDirector.Name = "tbAddDirector";
            this.tbAddDirector.Size = new System.Drawing.Size(465, 20);
            this.tbAddDirector.TabIndex = 12;
            // 
            // tbDeleteMovieYear
            // 
            this.tbDeleteMovieYear.Location = new System.Drawing.Point(312, 252);
            this.tbDeleteMovieYear.Name = "tbDeleteMovieYear";
            this.tbDeleteMovieYear.Size = new System.Drawing.Size(465, 20);
            this.tbDeleteMovieYear.TabIndex = 13;
            // 
            // tbSearchYear
            // 
            this.tbSearchYear.Location = new System.Drawing.Point(312, 389);
            this.tbSearchYear.Name = "tbSearchYear";
            this.tbSearchYear.Size = new System.Drawing.Size(465, 20);
            this.tbSearchYear.TabIndex = 14;
            // 
            // rtDisplay
            // 
            this.rtDisplay.Location = new System.Drawing.Point(239, 467);
            this.rtDisplay.Name = "rtDisplay";
            this.rtDisplay.ReadOnly = true;
            this.rtDisplay.Size = new System.Drawing.Size(538, 151);
            this.rtDisplay.TabIndex = 15;
            this.rtDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 630);
            this.Controls.Add(this.rtDisplay);
            this.Controls.Add(this.tbSearchYear);
            this.Controls.Add(this.tbDeleteMovieYear);
            this.Controls.Add(this.tbAddDirector);
            this.Controls.Add(this.tbAddMovieTitle);
            this.Controls.Add(this.tbAddMovieYear);
            this.Controls.Add(this.lblSearchYear);
            this.Controls.Add(this.lblDeleteMovieYear);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAddMovieYear);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Label lblAddMovieYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDeleteMovieYear;
        private System.Windows.Forms.Label lblSearchYear;
        private System.Windows.Forms.TextBox tbAddMovieYear;
        private System.Windows.Forms.TextBox tbAddMovieTitle;
        private System.Windows.Forms.TextBox tbAddDirector;
        private System.Windows.Forms.TextBox tbDeleteMovieYear;
        private System.Windows.Forms.TextBox tbSearchYear;
        private System.Windows.Forms.RichTextBox rtDisplay;
    }
}

