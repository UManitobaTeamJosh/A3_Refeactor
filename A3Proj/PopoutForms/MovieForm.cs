using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj.PopoutForms {
    public partial class MovieForm : DataForm {

        private Movie movie;
        A3Proj.TabPanels.MovieTabPanel parent;

        public MovieForm() {
            InitializeComponent();
        }

        public MovieForm(Movie initMovie, A3Proj.TabPanels.MovieTabPanel parent):this() {
            movie = initMovie;
            this.parent = parent;
            setFields();
        }

        private void setFields() {
            this.Text = movie.getTitle();
            label_MovieTitle.Text = movie.getTitle();
            //set description
            String description = movie.getLength() + " mins - ";
            foreach (String genre in movie.getGenres()) {
                description += genre + ",";
            }
            description += movie.getYear();
            label_basicMovieInfo.Text = description;
            //set director and actors
            String director = movie.getDirector();
            String[] actorArray = movie.getActors().ToArray();
            String actors = "";
            for (int i = 0; i < actorArray.Length; i++) {
                actors += ("    "+actorArray[i]);
                if (i + 1 < actorArray.Length) {
                    actors += "\n";
                }
            }
            String directorActorsDescription = "Director\n    " + director + "\nActors\n" + actors;
            label_DirectorActor.Text = directorActorsDescription;
            //Set review and user rating
            if (movie.getUserRating() >= 0 && movie.getUserRating() <= 10) {
                comboBox_Rating.Text = movie.getUserRating().ToString();
            }
            if (movie.getReview() != null) {
                richTextBox_Review.Text = movie.getReview();
            }
            //Set stars (database rating)
            if (movie.getRating() <= 10) {
                String ratingString = "";
                String negRatingString = "";
                for (int i = 0; i < movie.getRating(); i++) {
                    ratingString += "* ";
                }
                for (int i = 0; i < 10 - movie.getRating(); i++) {
                    negRatingString += "* ";
                }
                label_rating.Text = ratingString;
                label_NegRating.Text = negRatingString;
                if (movie.getRating() == 0) {
                    label_NegRating.Left = label_rating.Right;
                } else {
                    label_NegRating.Left = label_rating.Right - 10;
                }
            }
            //Set date
            String dateWatched = movie.getDateWatched();
            if (!String.IsNullOrWhiteSpace(dateWatched)) {
                radio_on.Checked = true;
                label_date.Text = dateWatched;
            } else {
                radio_not.Checked = true;
            }
        }

        private void button_AddShortlist_Click(object sender, EventArgs e) {
            button_AddShortlist.Enabled = false;
            parent.addMovieToShortlist(movie);
        }

        private void button_Save_Click(object sender, EventArgs e) {
            int userRating = Convert.ToInt32(comboBox_Rating.Text);
            String userReview = richTextBox_Review.Text;
            movie.changeUserRating(userRating);
            movie.setReview(userReview);
            //updateDate
            if (radio_on.Checked) {
                movie.setDateWatched(label_date.Text);
            } else {
                movie.setDateWatched("");
            }
            parent.updateMovie(movie);
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            radio_on.Checked = true;
            PopoutCalender calender = new PopoutCalender(this);
            calender.ShowDialog();
        }

        public void sendDate(String date) {
            label_date.Text = date;
        }

        private void NotWatchedChange(object sender, EventArgs e) {
            radioChange();
        }

        private void watchOnChange(object sender, EventArgs e) {
            radioChange();
        }

        private void radioChange() {
            if (radio_on.Checked) {
                label_date.Enabled = true;
                label_date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            } else {
                label_date.Enabled = false;
            }
        }


    }
}
