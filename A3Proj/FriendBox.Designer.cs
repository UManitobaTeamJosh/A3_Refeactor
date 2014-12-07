namespace A3Proj {
    partial class FriendBox {
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
            this.friendImage = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_FriendBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendImage)).BeginInit();
            this.contextMenuStrip_FriendBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // friendImage
            // 
            this.friendImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.friendImage.BackgroundImage = global::A3Proj.Properties.Resources.placeholder_movie;
            this.friendImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.friendImage.ContextMenuStrip = this.contextMenuStrip_FriendBox;
            this.friendImage.Location = new System.Drawing.Point(3, 2);
            this.friendImage.Margin = new System.Windows.Forms.Padding(2);
            this.friendImage.Name = "friendImage";
            this.friendImage.Size = new System.Drawing.Size(137, 161);
            this.friendImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendImage.TabIndex = 2;
            this.friendImage.TabStop = false;
            this.friendImage.Click += new System.EventHandler(this.click);
            // 
            // contextMenuStrip_FriendBox
            // 
            this.contextMenuStrip_FriendBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToPartyToolStripMenuItem,
            this.editFriendToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_FriendBox.Name = "contextMenuStrip_FriendBox";
            this.contextMenuStrip_FriendBox.Size = new System.Drawing.Size(141, 70);
            // 
            // addToPartyToolStripMenuItem
            // 
            this.addToPartyToolStripMenuItem.Name = "addToPartyToolStripMenuItem";
            this.addToPartyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addToPartyToolStripMenuItem.Text = "Add to party";
            this.addToPartyToolStripMenuItem.Click += new System.EventHandler(this.addToPartyToolStripMenuItem_Click);
            // 
            // editFriendToolStripMenuItem
            // 
            this.editFriendToolStripMenuItem.Name = "editFriendToolStripMenuItem";
            this.editFriendToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.editFriendToolStripMenuItem.Text = "Edit";
            this.editFriendToolStripMenuItem.Click += new System.EventHandler(this.editFriendToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.ContextMenuStrip = this.contextMenuStrip_FriendBox;
            this.label_Name.Location = new System.Drawing.Point(4, 169);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(84, 13);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "FRIEND_NAME";
            this.label_Name.Click += new System.EventHandler(this.click);
            // 
            // FriendBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip_FriendBox;
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.friendImage);
            this.Name = "FriendBox";
            this.Size = new System.Drawing.Size(146, 189);
            this.Click += new System.EventHandler(this.click);
            ((System.ComponentModel.ISupportInitialize)(this.friendImage)).EndInit();
            this.contextMenuStrip_FriendBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox friendImage;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_FriendBox;
        private System.Windows.Forms.ToolStripMenuItem addToPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}
