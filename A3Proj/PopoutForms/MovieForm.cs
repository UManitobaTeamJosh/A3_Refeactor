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
        }

        private void button_AddShortlist_Click(object sender, EventArgs e) {
            button_AddShortlist.Enabled = false;
            parent.addMovieToShortlist(movie);
        }


    }
}
