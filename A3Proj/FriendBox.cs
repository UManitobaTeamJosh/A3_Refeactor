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
    public partial class FriendBox : UserControl {

        A3Proj.TabPanels.FriendsTabPanel parent;
        private Friend friend;
        private int index;

        public FriendBox(A3Proj.TabPanels.FriendsTabPanel parent ,Friend friend, int index) {
            InitializeComponent();
            this.parent = parent;
            this.friend = friend;
            this.index = index;
            label_Name.Text = friend.name;
            if (!String.IsNullOrWhiteSpace(friend.imageFilePath) && System.IO.File.Exists(friend.imageFilePath)) {
                friendImage.BackgroundImage = new Bitmap(friend.imageFilePath);
                Console.WriteLine("Image set");
            }
        }

        private void editFriendToolStripMenuItem_Click(object sender, EventArgs e) {
            parent.editFriend(index);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            parent.deleteFriend(index);
        }

        private void addToPartyToolStripMenuItem_Click(object sender, EventArgs e) {
            parent.addFriendToParty(index);
        }

        private void click(object sender, EventArgs e) {
            parent.editFriend(index);
        }

    }
}
