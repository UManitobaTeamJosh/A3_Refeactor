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
    public partial class FriendForm : Form {

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
         *  TODO - This might be unnecessary? Just use genreCheckedList.CheckedItems
         */
        private List<String> generateFavoriteGenres() {
            List<String> list = new List<String>();
            foreach (String genre in genreCheckedList.CheckedItems) {
                list.Add(genre.ToString());
            }
            return list;
        }

        private void setNameLabel(String candidate) {
            if (String.IsNullOrWhiteSpace(candidate)) {
                label_Name.Text = "Enter name here";
                label_Name.Font = new Font(label_Name.Font.Name, label_Name.Font.Size, FontStyle.Italic);
            } else {
                label_Name.Text = name;
                label_Name.Font = new Font(label_Name.Font.Name, label_Name.Font.Size,FontStyle.Regular);
            }
        }

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
            } else {
                Console.WriteLine("friend gen fail - name invalid");
            }
            return friend;
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e) {
            if (!edit) {
                parent.addFriend(generateFriend());
            } else {
                friend.name = name;
                friend.favoriteGenres = generateFavoriteGenres();
                friend.imageFilePath = imageFilePath;
                parent.editFriendData(friend, friend.index);
            }
            this.Close();
        }

        private void leave_textBoxName(object sender, EventArgs e) {
            leaveTextBoxName();
        }

        private void button_setImage_Click(object sender, EventArgs e) {
            using (OpenFileDialog oFD = new OpenFileDialog()) {
                oFD.Title = "Select Image";
                oFD.Filter = "Image Files (*.png) | *.png;*.jpg;*.jpeg;*.bmp";
                if (oFD.ShowDialog() == DialogResult.OK) {
                    pictureBox1.BackgroundImage = new Bitmap(oFD.FileName);
                    //Console.WriteLine(oFD.FileName);
                    imageFilePath = oFD.FileName;
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e) {
            imageFilePath = "";
            pictureBox1.BackgroundImage = Properties.Resources.placeholder_movie;
        }



    }
}
