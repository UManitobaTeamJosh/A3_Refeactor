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
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     * FriendForm allows the user to edit and create new friends.
     */
    public partial class FriendForm : DataForm {

        A3Proj.TabPanels.FriendsTabPanel parent;
        Friend friend;
        private String name;
        private bool edit;
        private String imageFilePath;

        /*
         *  Instantiating NewFriendForm with only a FriendsTabLabel sets up the
         *  form so create a new friend.
         */
        public FriendForm(A3Proj.TabPanels.FriendsTabPanel parent) {
            InitializeComponent();
            edit = false;
            this.parent = parent;
            name = "";
            label_Name.Text = "Enter name here";
            label_Name.Font = new Font(label_Name.Font.Name,label_Name.Font.Size,FontStyle.Italic);
        }

        /*
         *  Instantiating NewFriendForm with a FriendsTabLabel and a Friend sets up
         *  the form to edit an existing friend.
         */
        public FriendForm(A3Proj.TabPanels.FriendsTabPanel parent, Friend friend):this(parent) {
            edit = true;
            this.friend = friend;
            this.Text = "Edit Friend";
            this.imageFilePath = friend.imageFilePath;
            label_Name.Text = friend.name;
            label_Name.Font = new Font(label_Name.Font.Name, label_Name.Font.Size, FontStyle.Regular);
            this.name = friend.name;
            //load favorite genres
            for (int i = 0; i < genreCheckedList.Items.Count; i++) {
                if (friend.favoriteGenres.Contains(genreCheckedList.Items[i])) {
                    genreCheckedList.SetItemChecked(i,true);
                }
            }
            //Load image
            try {
                String imageFilePath = friend.imageFilePath;
                if(System.IO.File.Exists(imageFilePath)){
                    pictureBox1.BackgroundImage = new Bitmap(friend.imageFilePath);
                }
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            //load recc movies
            foreach (String movie in friend.recMovies) {
                listbox_reccMovies.Items.Add(movie);
            }
        }

        /*
         *  Returns true if the candidateName is valid. 
         *  False if it is not.
         *  
         *  The only conditions for validity are not null, and not  whitespace.
         */
        private bool validName(String candidateName) {
            bool output = true;
            if (String.IsNullOrWhiteSpace(candidateName)) {
                output = false;
            }
            return output;
        }

        /*
         *  Creates a list of the genres checked off in the genreCheckedList
         */
        private List<String> generateFavoriteGenres() {
            List<String> list = new List<String>();
            foreach (String genre in genreCheckedList.CheckedItems) {
                list.Add(genre.ToString());
            }
            return list;
        }

        /*
         * Sets the contents of label_Name.
         * If it's ever empty, it should be italicized so the user knows that it's not some Friend that's
         * been unusually titled "Enter name here" and that there just hasn't been a name chosen yet.
         */
        private void setNameLabel(String candidate) {
            if (String.IsNullOrWhiteSpace(candidate)) {
                label_Name.Text = "Enter name here";
                label_Name.Font = new Font(label_Name.Font.Name, label_Name.Font.Size, FontStyle.Italic);
            } else {
                label_Name.Text = name;
                label_Name.Font = new Font(label_Name.Font.Name, label_Name.Font.Size,FontStyle.Regular);
            }
        }

        /*
         *  The user should be unable to leave to textBox until they provide a valid name.
         *  When they do leave, change what controls are enabled/disabled to communicate to the user
         *  that they're no longer editing the name.
         */
        private void leaveTextBoxName() {
            if (validName(textBox_Name.Text)) {
                name = textBox_Name.Text;
                setNameLabel(name);
                button_editName.Enabled = true;
                label_Name.Visible = true;
                textBox_Name.Visible = false;
                textBox_Name.Enabled = false;
            } else {
                textBox_Name.Focus();
                MessageBox.Show("Invalid name. Please enter a valid name.");
            }
        }

        /*
         *  Swap visibility of label_Name and textBox_Name. 
         *  Set focus to textBox.
         */
        private void button_editName_Click(object sender, EventArgs e) {
            label_Name.Visible = false;
            textBox_Name.Visible = true;
            textBox_Name.Enabled = true;
            button_editName.Enabled = false;
            textBox_Name.Focus();
            textBox_Name.Text = name;
        }

        /*
         *  Pressing the "Enter" key is an alternative way to finish editing the name.
         */
        private void textBox_name_keydown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString().Equals("Return")) {
                leaveTextBoxName();
            }
        }

        /*
         *  Creates a new friend based on the fields the user has set.
         *  If the name is invalid, a NULL Friend is returned.
         */
        private Friend generateFriend() {
            Friend friend = null;
            if (!String.IsNullOrWhiteSpace(name)) {
                friend = new Friend(name,generateFavoriteGenres());
                friend.imageFilePath = imageFilePath;
                friend.recMovies = stringListFromListBox();
            } else {
                Console.WriteLine("friend gen fail - name invalid");
            }
            return friend;
        }

        /*
         * Just closes the form.
         */
        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        /*
         *  Depending on whether or not this form was instantiated with the intent of editing
         *  an existing friend or creating a new one, we call a different method from the parent 
         *  FriendTabPanel form.
         */
        private void button_Save_Click(object sender, EventArgs e) {
            if (!edit) {
                parent.addFriend(generateFriend());
            } else {
                friend.name = name;
                friend.favoriteGenres = generateFavoriteGenres();
                friend.imageFilePath = imageFilePath;
                friend.recMovies = stringListFromListBox();
                parent.editFriendData(friend, friend.index);
            }
            this.Close();
        }

        /*
         *  Collects the recommended movies from the listBox.
         */
        private List<String> stringListFromListBox() {
            List<String> movies = new List<String>();
            for (int i = 0; i < listbox_reccMovies.Items.Count; i++) {
                movies.Add(listbox_reccMovies.Items[i].ToString());
            }
                return movies;
        }

        /*
         * There are a number of ways to try and leave the textbox. 
         */
        private void leave_textBoxName(object sender, EventArgs e) {
            leaveTextBoxName();
        }

        /*
         *  Allow user to select an image path using an OpenFileDialog.
         *  Save the path and update the image.
         */
        private void button_setImage_Click(object sender, EventArgs e) {
            using (OpenFileDialog oFD = new OpenFileDialog()) {
                oFD.Title = "Select Image";
                oFD.Filter = "Image Files (*.png) | *.png;*.jpg;*.jpeg;*.bmp";
                if (oFD.ShowDialog() == DialogResult.OK) {
                    pictureBox1.BackgroundImage = new Bitmap(oFD.FileName);
                    imageFilePath = oFD.FileName;
                }
            }
        }

        /*
         *  Clears the user image and returns the box to the default "No Image" place-holder image.
         */
        private void button_clear_Click(object sender, EventArgs e) {
            imageFilePath = "";
            pictureBox1.BackgroundImage = Properties.Resources.placeholder_movie;
        }

        /*
         *  Adds whatever is in the textbox as a recommended movie.
         *  There's no requirement for the movie to exist in the database to be recommended
         */
        private void button_addMovie_Click(object sender, EventArgs e) {
            String newMovieTitle = textBox_newRecMovie.Text;
            if (!String.IsNullOrWhiteSpace(newMovieTitle)) {
                listbox_reccMovies.Items.Add(newMovieTitle);
                textBox_newRecMovie.Text = "";
            } else {
                MessageBox.Show("Please fill the text box before adding a movie");
            }
        }

        /*
         *  Allow user to remove movies by right clicking.
         */
        private void removeMovieToolStripMenuItem3_Click(object sender, EventArgs e) {
            if (listbox_reccMovies.SelectedIndex >= 0 && listbox_reccMovies.SelectedIndex < listbox_reccMovies.Items.Count) {
                listbox_reccMovies.Items.RemoveAt(listbox_reccMovies.SelectedIndex);
            }
        }



    }
}
