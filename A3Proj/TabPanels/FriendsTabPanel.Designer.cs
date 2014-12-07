namespace A3Proj.TabPanels {
    partial class FriendsTabPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label_ReccMovies = new System.Windows.Forms.Label();
            this.listBox_ReccGenres = new System.Windows.Forms.ListBox();
            this.label_reccGenres = new System.Windows.Forms.Label();
            this.listBox_party = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_party = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_CurrentParty = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_addFriend = new System.Windows.Forms.Label();
            this.button_addFriend = new System.Windows.Forms.Button();
            this.flowPanelLayout_Friends = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.contextMenuStrip_party.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label_ReccMovies);
            this.panel1.Controls.Add(this.listBox_ReccGenres);
            this.panel1.Controls.Add(this.label_reccGenres);
            this.panel1.Controls.Add(this.listBox_party);
            this.panel1.Controls.Add(this.label_CurrentParty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 632);
            this.panel1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 446);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 147);
            this.listBox2.TabIndex = 5;
            // 
            // label_ReccMovies
            // 
            this.label_ReccMovies.AutoSize = true;
            this.label_ReccMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ReccMovies.Location = new System.Drawing.Point(3, 422);
            this.label_ReccMovies.Name = "label_ReccMovies";
            this.label_ReccMovies.Size = new System.Drawing.Size(167, 16);
            this.label_ReccMovies.TabIndex = 4;
            this.label_ReccMovies.Text = "Recommended Movies";
            // 
            // listBox_ReccGenres
            // 
            this.listBox_ReccGenres.FormattingEnabled = true;
            this.listBox_ReccGenres.Location = new System.Drawing.Point(12, 253);
            this.listBox_ReccGenres.Name = "listBox_ReccGenres";
            this.listBox_ReccGenres.Size = new System.Drawing.Size(150, 147);
            this.listBox_ReccGenres.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBox_ReccGenres, "Genres recommended based on your party.");
            // 
            // label_reccGenres
            // 
            this.label_reccGenres.AutoSize = true;
            this.label_reccGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reccGenres.Location = new System.Drawing.Point(3, 229);
            this.label_reccGenres.Name = "label_reccGenres";
            this.label_reccGenres.Size = new System.Drawing.Size(167, 16);
            this.label_reccGenres.TabIndex = 2;
            this.label_reccGenres.Text = "Recommended Genres";
            // 
            // listBox_party
            // 
            this.listBox_party.ContextMenuStrip = this.contextMenuStrip_party;
            this.listBox_party.FormattingEnabled = true;
            this.listBox_party.Location = new System.Drawing.Point(13, 39);
            this.listBox_party.Name = "listBox_party";
            this.listBox_party.Size = new System.Drawing.Size(150, 173);
            this.listBox_party.TabIndex = 1;
            this.toolTip1.SetToolTip(this.listBox_party, "Left click to select, then right click to remove a friend from the party");
            // 
            // contextMenuStrip_party
            // 
            this.contextMenuStrip_party.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromPartyToolStripMenuItem});
            this.contextMenuStrip_party.Name = "contextMenuStrip_party";
            this.contextMenuStrip_party.Size = new System.Drawing.Size(223, 26);
            // 
            // removeFromPartyToolStripMenuItem
            // 
            this.removeFromPartyToolStripMenuItem.Name = "removeFromPartyToolStripMenuItem";
            this.removeFromPartyToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.removeFromPartyToolStripMenuItem.Text = "Remove selected from party";
            this.removeFromPartyToolStripMenuItem.Click += new System.EventHandler(this.removeFromPartyToolStripMenuItem_Click);
            // 
            // label_CurrentParty
            // 
            this.label_CurrentParty.AutoSize = true;
            this.label_CurrentParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentParty.Location = new System.Drawing.Point(25, 9);
            this.label_CurrentParty.Name = "label_CurrentParty";
            this.label_CurrentParty.Size = new System.Drawing.Size(118, 24);
            this.label_CurrentParty.TabIndex = 0;
            this.label_CurrentParty.Text = "Current Party";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_addFriend);
            this.panel2.Controls.Add(this.button_addFriend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(174, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 61);
            this.panel2.TabIndex = 1;
            // 
            // label_addFriend
            // 
            this.label_addFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_addFriend.AutoSize = true;
            this.label_addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addFriend.Location = new System.Drawing.Point(332, 21);
            this.label_addFriend.Name = "label_addFriend";
            this.label_addFriend.Size = new System.Drawing.Size(105, 24);
            this.label_addFriend.TabIndex = 1;
            this.label_addFriend.Text = "Add Friend";
            // 
            // button_addFriend
            // 
            this.button_addFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addFriend.Location = new System.Drawing.Point(448, 12);
            this.button_addFriend.Name = "button_addFriend";
            this.button_addFriend.Size = new System.Drawing.Size(42, 41);
            this.button_addFriend.TabIndex = 0;
            this.button_addFriend.Text = "+";
            this.toolTip1.SetToolTip(this.button_addFriend, "Add a new friend.");
            this.button_addFriend.UseVisualStyleBackColor = true;
            this.button_addFriend.Click += new System.EventHandler(this.button_addFriend_Click);
            // 
            // flowPanelLayout_Friends
            // 
            this.flowPanelLayout_Friends.AutoScroll = true;
            this.flowPanelLayout_Friends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelLayout_Friends.Location = new System.Drawing.Point(174, 61);
            this.flowPanelLayout_Friends.Name = "flowPanelLayout_Friends";
            this.flowPanelLayout_Friends.Size = new System.Drawing.Size(508, 571);
            this.flowPanelLayout_Friends.TabIndex = 2;
            // 
            // FriendsTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanelLayout_Friends);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FriendsTabPanel";
            this.Size = new System.Drawing.Size(682, 632);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip_party.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_addFriend;
        private System.Windows.Forms.Button button_addFriend;
        private System.Windows.Forms.Label label_CurrentParty;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label_ReccMovies;
        private System.Windows.Forms.ListBox listBox_ReccGenres;
        private System.Windows.Forms.Label label_reccGenres;
        private System.Windows.Forms.ListBox listBox_party;
        private System.Windows.Forms.FlowLayoutPanel flowPanelLayout_Friends;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_party;
        private System.Windows.Forms.ToolStripMenuItem removeFromPartyToolStripMenuItem;

    }
}
