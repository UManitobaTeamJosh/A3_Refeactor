using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

/*
 *  The "Friends" tab panel.
 *  All saving and loading; all processing of friends is handled here.
 */
namespace A3Proj.TabPanels {
    public partial class FriendsTabPanel : TabPanel {

        private static readonly String FRIENDS_SAVE_FILE_NAME = "friends.xml";
        private List<Friend> friendList;
        private List<Friend> party;

        public FriendsTabPanel() {
            InitializeComponent();
            loadFriendsFromXML();
            populateTable();
            party = new List<Friend>();
        }

        /*
         *  Adds a friend with the specified idnex to the party.
         */
        public void addFriendToParty(int index) {
            party.Add(friendList[index]);
            populatePartyListBox();
            updateRecGenres();
        }

        /*
         *  Opens a FrienForm configured to edit a friend.
         */
        public void editFriend(int index) {
            A3Proj.PopoutForms.FriendForm friendForm = new A3Proj.PopoutForms.FriendForm(this,friendList[index]);
            friendForm.ShowDialog();
        }

        /*
         * Deletes the friend with the specified index. Refreshes the flowPanel
         * and saves the changes.
         */
        public void deleteFriend(int index) {
            friendList.RemoveAt(index);
            populateTable();
            saveFriendsData();
        }

        /*
         *  Counts all occurrences of genres among the friends in the party.
         *  Those that appear the most are recommended.
         *  
         * In the prototype (this) this method returns the single first-occurring
         * genre with the most favorites.
         */
        private void updateRecGenres() {
            List<matchingGenre> list = new List<matchingGenre>();
            foreach (Friend friend in party) {
                foreach (String genre in friend.favoriteGenres) {
                    bool found = false;
                    foreach (matchingGenre mGenre in list) {
                        if (mGenre.genreName.Equals(genre)) {
                            found = true;
                            mGenre.count++;
                        }
                    }//each mGenre
                    if (!found) {
                        list.Add(new matchingGenre(genre));
                    }
                }//each genre
            }//each friend
            matchingGenre mostCommon = new matchingGenre("invalid");
            mostCommon.count = -1;
            foreach (matchingGenre mG in list) {
                Console.WriteLine(mG.toString());
                if (mG.count > mostCommon.count) {
                    mostCommon = mG;
                }
            }
            if (!mostCommon.genreName.Equals("invalid")) {
                listBox_ReccGenres.Items.Clear();
                listBox_ReccGenres.Items.Add(mostCommon.toString());
            }
        }
        /*
         *  Inner class for updateRecGenres. Keeps track of how many
         *  people favorite a certain genre.
         *  Count starts at one since if a matchingGenre exists at all, that implies
         *  that at least one person likes the genre.
         */
        class matchingGenre{
            public String genreName;
            public int count = 1;
            public matchingGenre(String name) {
                genreName = name;
            }
            public String toString() {
                return genreName + "--" + count + " favorited";
            }
        }

        /*
         *  Populates the party list box with Friends
         */
        private void populatePartyListBox() {
            listBox_party.Items.Clear();
            foreach (Friend friend in party) {
                listBox_party.Items.Add(friend.name);
            }
        }

        /*
         *  Populates flowPanelLayout_Friends with all friends in the friends list.
         *  Also assigns/updates index numbers to Friends so they can be referenced
         *  by other controls.
         */
        private void populateTable() {
            flowPanelLayout_Friends.Controls.Clear();
            int index = 0;
            foreach (Friend friend in friendList) {
                friend.index = index;
                FriendBox friendBox = new FriendBox(this,friend,index);
                flowPanelLayout_Friends.Controls.Add(friendBox);
                index++;
            }
            if (friendList.Count == 0) {
                Label label = new Label();
                label.Text = "No friends found!";
                flowPanelLayout_Friends.Controls.Add(label);
            }
        }

        /*
         *  Modify friends with maching indexes in both the main friends list
         *  and also any friends referenced in the current party.
         */
        public void editFriendData(Friend friend, int index) {
            foreach (String s in friend.recMovies) {
                Console.WriteLine(s);
            }
            friendList[index] = friend;
            for (int i = 0; i < party.Count; i++) {
                if (party[i].index == index) {
                    party[i] = friend;
                    populatePartyListBox();
                }
            }
            populateTable();
            saveFriendsData();
        }

        /*
         *  Adds a new friend then refreshes the table.
         *  Saves changes to friends data;
         */
        public void addFriend(Friend newFriend) {
            if (newFriend != null) {
                friendList.Add(newFriend);
                populateTable();
                saveFriendsData();
            }
        }

        /*
         *  Attempts to load friend data from the XML named in FRIENDS_SAVE_FILE_NAME.
         *  If the file cannot be located, an empty friendList is created instead.
         */
        private void loadFriendsFromXML() {
            if (System.IO.File.Exists(FRIENDS_SAVE_FILE_NAME)) {
                XDocument xmlSource = XDocument.Load(FRIENDS_SAVE_FILE_NAME);
                IEnumerable<XElement> items = xmlSource.Descendants("friend");
                List<Friend> tempFriendList = new List<Friend>();
                foreach (var p in items) {
                    IEnumerable<XElement> elementItems = p.Descendants();
                    String name = null;
                    String imagePath = null;
                    List<String> genreList = new List<String>();
                    List<String> movieList = new List<String>();
                    foreach (var p2 in elementItems) {
                        String elementName = p2.Name.ToString();
                        if (elementName.Equals("name")) {
                            name = p2.Value;
                        } else if (elementName.Equals("genre")) {
                            genreList.Add(p2.Value);
                        } else if (elementName.Equals("imagePath")) {
                            imagePath = p2.Value;
                        } else if (elementName.Equals("movieTitle")) {
                            movieList.Add(p2.Value);
                        }
                    }//foreach inner
                    Friend newFriend = new Friend(name,genreList);
                    newFriend.imageFilePath = imagePath;
                    newFriend.recMovies = movieList;
                    tempFriendList.Add(newFriend);
                }//foreach outer
                friendList = tempFriendList;
            } else {
                friendList = new List<Friend>();
            }
        }

        /*
         *  Saves friends to file.
         */
        private void saveFriendsData() {
            XDocument xdoc = new XDocument(new XElement("friendList"));
            foreach (Friend friend in friendList) {
                XElement root = new XElement("friend");
                root.Add(new XElement("name",friend.name));
                root.Add(new XElement("imagePath", friend.imageFilePath));
                foreach (String genre in friend.favoriteGenres) {
                    root.Add(new XElement("genre",genre));
                }
                foreach (String movie in friend.recMovies) {
                    root.Add(new XElement("movieTitle", movie));
                }
                xdoc.Element("friendList").Add(root);
            }
            xdoc.Save(FRIENDS_SAVE_FILE_NAME);
        }

        /*
         *  Clicking the add friend button opens a new friend form.
         */
        private void button_addFriend_Click(object sender, EventArgs e) {
            A3Proj.PopoutForms.FriendForm friendForm = new A3Proj.PopoutForms.FriendForm(this);
            friendForm.ShowDialog();
        }

        private void removeFromPartyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (listBox_party.SelectedIndex >= 0 && listBox_party.SelectedIndex < listBox_party.Items.Count) {
                party.RemoveAt(listBox_party.SelectedIndex);
                populatePartyListBox();
                updateRecGenres();
            }
        }//saveFriendsData

    }
}
