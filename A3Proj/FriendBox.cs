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
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     * FriendBox represents a Friend in FriendTabPanel.
     */
    public partial class FriendBox : UserControl {

        private A3Proj.TabPanels.FriendsTabPanel parent;
        private Friend friend;
        private int index; //Used to track references to Friends

        
        public FriendBox(A3Proj.TabPanels.FriendsTabPanel parent ,Friend friend, int index) {
            InitializeComponent();
            this.parent = parent;
            this.friend = friend;
            this.index = index;
            label_Name.Text = friend.name;
            if (!String.IsNullOrWhiteSpace(friend.imageFilePath) && System.IO.File.Exists(friend.imageFilePath)) {
                friendImage.BackgroundImage = new Bitmap(friend.imageFilePath);
            }
        }

        //Clicking "edit" context menu opens a NewFriendForm configured to edit an existing Friend.
        private void editFriendToolStripMenuItem_Click(object sender, EventArgs e) {
            parent.editFriend(index);
        }

        //Clicking "delete" context menu deletes the friend.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            parent.deleteFriend(index);
        }

        //Clicking "add to party" context menu adds the friend to the party
        private void addToPartyToolStripMenuItem_Click(object sender, EventArgs e) {
            parent.addFriendToParty(index);
        }

        //Clicking the friend opens a NewFriendForm configured to edit an existing Friend.
        private void click(object sender, EventArgs e) {
            parent.editFriend(index);
        }

    }
}
