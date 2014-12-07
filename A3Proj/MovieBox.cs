using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj {
    /*
     * TODO Use auto ellipsize instead of manual code
     */
    public partial class MovieBox : UserControl {

        private static readonly int ELLIPSIZE_LIMIT = 22;

        private Movie movie;
        private A3Proj.TabPanels.MovieTabPanel parent;
        private int ratingDisplayMode = 0;

        

        public MovieBox() {
            InitializeComponent();
        }

        /*
         *  If rating display is not specified, show the database rating (not user rating)
         */
        public MovieBox(Movie movie, A3Proj.TabPanels.MovieTabPanel parent) : this() {
            this.movie = movie;
            this.parent = parent;
            this.labelMovieYear.Text = movie.getYear().ToString();
            setToolTips(movie.getTitle());
            setTitle(movie.getTitle());
            setRatings();
        }

        public MovieBox(Movie movie, A3Proj.TabPanels.MovieTabPanel parent,int ratingDisplayMode): this(movie,parent) {
            this.ratingDisplayMode = ratingDisplayMode;
            if (ratingDisplayMode == 2) {
                this.Height = 269;
            }
            setRatings();
            setWatched();
        }

        /*
         * Sets the tooltip for MovieBox itself and all of its child controls.
         * Tooltip is set dynamically, so cannot be defined in Designer.cs
         */
        private void setToolTips(string text) {
            this.toolTip1.SetToolTip(this, movie.getTitle());
            foreach (Control control in this.Controls) {
                this.toolTip1.SetToolTip(control, text);
            }
        }

        private void setRatings() {
            Label someRating = label_rating;
            someRating.Text = "";
            label_negRating.Text = "";
            label_negRatingUser.Text = "";
            label_userRating.Text = "";
            int rating = movie.getRating();
            if (ratingDisplayMode == 1) {
                rating = movie.getUserRating();
            }
            if (rating <= 10) {
                String ratingString = "";
                for (int i = 0; i < rating; i++) {
                    ratingString += "* ";
                }
                someRating.Text = ratingString;
                //Do empty stars now
                String negRatingString = "";
                for (int i = 0; i < 10 - rating; i++) {
                    negRatingString += "* ";
                }
                if (rating <= 10) {
                    Label negRating = label_negRating;
                    negRating.Text = negRatingString;
                    if (rating == 0) {
                        negRating.Left = label_rating.Left;
                    } else {
                        negRating.Left = label_rating.Right - 5;
                    }
                }
            }
            //If we're showing both...
            if (ratingDisplayMode == 2) {
                rating = movie.getUserRating();
                if (rating <= 10) {
                    String ratingString = "";
                    for (int i = 0; i < rating; i++) {
                        ratingString += "* ";
                    }
                    label_userRating.Text = ratingString;
                    String negRatingString = "";
                    for (int i = 0; i < 10 - rating; i++) {
                        negRatingString += "* ";
                    }
                    label_negRatingUser.Text = negRatingString;
                    if (rating == 0) {
                        label_negRatingUser.Left = label_userRating.Left;
                    } else {
                        label_negRatingUser.Left = label_userRating.Right-5;
                    }
                }
            }
        }

        private void setWatched() {
            String date = movie.getDateWatched();
            if (!String.IsNullOrWhiteSpace(date)) {
                label_watched.Visible = true;
            }
        }

        /*
         *  Sets the title of the film.
         *  If the length exceeds the ELLIPSIZE_LIMIT then it is truncated 
         *  with a "..." representing the missing characters.
         */
        private void setTitle(string title) {
            if (title.Length > ELLIPSIZE_LIMIT) {
                title = title.Substring(0,ELLIPSIZE_LIMIT-1);
                title += "...";
            }
            this.labelMovieTitle.Text = title;
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void MovieBox_Load(object sender, EventArgs e) {

        }

        private void click(object sender, EventArgs e) {
            parent.openMovieForm(movie);
        }

        private void dragStart(object sender, MouseEventArgs e) {
            this.DoDragDrop(movie.getTitle(), DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void dradDrop(object sender, DragEventArgs e) {
            parent.openMovieForm(movie);
        }

        private void dragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
