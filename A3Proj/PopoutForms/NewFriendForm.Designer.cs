namespace A3Proj.PopoutForms {
    partial class FriendForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_editName = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genreCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label_FavGenre = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_setImage = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.listbox_reccMovies = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeMovieToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_newRecMovie = new System.Windows.Forms.TextBox();
            this.button_addMovie = new System.Windows.Forms.Button();
            this.removeMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMovieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMovieToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::A3Proj.Properties.Resources.placeholder_movie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.AutoEllipsis = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(205, 13);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(264, 31);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "%Friend Name%";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(211, 10);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(315, 38);
            this.textBox_Name.TabIndex = 3;
            this.textBox_Name.Visible = false;
            this.textBox_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_name_keydown);
            this.textBox_Name.Leave += new System.EventHandler(this.leave_textBoxName);
            // 
            // button_editName
            // 
            this.button_editName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_editName.Location = new System.Drawing.Point(532, 13);
            this.button_editName.Name = "button_editName";
            this.button_editName.Size = new System.Drawing.Size(79, 31);
            this.button_editName.TabIndex = 4;
            this.button_editName.Text = "Edit Name";
            this.toolTip1.SetToolTip(this.button_editName, "Edit friend\'s name");
            this.button_editName.UseVisualStyleBackColor = true;
            this.button_editName.Click += new System.EventHandler(this.button_editName_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.genreCheckedList);
            this.panel1.Controls.Add(this.label_FavGenre);
            this.panel1.Location = new System.Drawing.Point(211, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 232);
            this.panel1.TabIndex = 6;
            // 
            // genreCheckedList
            // 
            this.genreCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreCheckedList.FormattingEnabled = true;
            this.genreCheckedList.Items.AddRange(new object[] {
            "Action",
            "Adult",
            "Adventure",
            "Animation",
            "Biography",
            "Comedy",
            "Crime",
            "Documentary",
            "Drama",
            "Family",
            "Fantasy",
            "Film-Noir",
            "History",
            "Horror",
            "Music",
            "Musical",
            "Mystery",
            "Reality-TV",
            "Romance",
            "Sci-Fi",
            "Short",
            "Sport",
            "Thriller",
            "War",
            "Western"});
            this.genreCheckedList.Location = new System.Drawing.Point(0, 13);
            this.genreCheckedList.Name = "genreCheckedList";
            this.genreCheckedList.ScrollAlwaysVisible = true;
            this.genreCheckedList.Size = new System.Drawing.Size(398, 217);
            this.genreCheckedList.TabIndex = 25;
            this.toolTip1.SetToolTip(this.genreCheckedList, "Check off this friend\'s favorite genres.");
            // 
            // label_FavGenre
            // 
            this.label_FavGenre.AutoSize = true;
            this.label_FavGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_FavGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FavGenre.Location = new System.Drawing.Point(0, 0);
            this.label_FavGenre.Name = "label_FavGenre";
            this.label_FavGenre.Size = new System.Drawing.Size(97, 13);
            this.label_FavGenre.TabIndex = 8;
            this.label_FavGenre.Text = "Favorite Genres";
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(537, 549);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button_cancel, "Discard changes.");
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(456, 549);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Save Friend";
            this.toolTip1.SetToolTip(this.button_Save, "Save changes");
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_setImage
            // 
            this.button_setImage.Location = new System.Drawing.Point(12, 252);
            this.button_setImage.Name = "button_setImage";
            this.button_setImage.Size = new System.Drawing.Size(98, 26);
            this.button_setImage.TabIndex = 9;
            this.button_setImage.Text = "Set Image";
            this.toolTip1.SetToolTip(this.button_setImage, "Choose an image for the friend.");
            this.button_setImage.UseVisualStyleBackColor = true;
            this.button_setImage.Click += new System.EventHandler(this.button_setImage_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(116, 252);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(73, 26);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear Image";
            this.toolTip1.SetToolTip(this.button_clear, "Remove this friend\'s image.");
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // listbox_reccMovies
            // 
            this.listbox_reccMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_reccMovies.ContextMenuStrip = this.contextMenuStrip1;
            this.listbox_reccMovies.FormattingEnabled = true;
            this.listbox_reccMovies.Location = new System.Drawing.Point(18, 326);
            this.listbox_reccMovies.Name = "listbox_reccMovies";
            this.listbox_reccMovies.Size = new System.Drawing.Size(594, 199);
            this.listbox_reccMovies.TabIndex = 11;
            this.toolTip1.SetToolTip(this.listbox_reccMovies, "Right click to remove selected movies");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMovieToolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // removeMovieToolStripMenuItem3
            // 
            this.removeMovieToolStripMenuItem3.Name = "removeMovieToolStripMenuItem3";
            this.removeMovieToolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.removeMovieToolStripMenuItem3.Text = "Remove movie";
            this.removeMovieToolStripMenuItem3.Click += new System.EventHandler(this.removeMovieToolStripMenuItem3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recommended Movies";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(7, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 2);
            this.panel2.TabIndex = 13;
            // 
            // textBox_newRecMovie
            // 
            this.textBox_newRecMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_newRecMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newRecMovie.Location = new System.Drawing.Point(335, 295);
            this.textBox_newRecMovie.Name = "textBox_newRecMovie";
            this.textBox_newRecMovie.Size = new System.Drawing.Size(191, 26);
            this.textBox_newRecMovie.TabIndex = 14;
            // 
            // button_addMovie
            // 
            this.button_addMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addMovie.Location = new System.Drawing.Point(532, 295);
            this.button_addMovie.Name = "button_addMovie";
            this.button_addMovie.Size = new System.Drawing.Size(75, 26);
            this.button_addMovie.TabIndex = 15;
            this.button_addMovie.Text = "Add Movie";
            this.toolTip1.SetToolTip(this.button_addMovie, "Add movie to Recommended Movies");
            this.button_addMovie.UseVisualStyleBackColor = true;
            this.button_addMovie.Click += new System.EventHandler(this.button_addMovie_Click);
            // 
            // removeMovieToolStripMenuItem
            // 
            this.removeMovieToolStripMenuItem.Name = "removeMovieToolStripMenuItem";
            this.removeMovieToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removeMovieToolStripMenuItem.Text = "Remove movie";
            // 
            // removeMovieToolStripMenuItem1
            // 
            this.removeMovieToolStripMenuItem1.Name = "removeMovieToolStripMenuItem1";
            this.removeMovieToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.removeMovieToolStripMenuItem1.Text = "Remove movie";
            // 
            // removeMovieToolStripMenuItem2
            // 
            this.removeMovieToolStripMenuItem2.Name = "removeMovieToolStripMenuItem2";
            this.removeMovieToolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.removeMovieToolStripMenuItem2.Text = "Remove movie";
            // 
            // FriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 584);
            this.Controls.Add(this.button_addMovie);
            this.Controls.Add(this.textBox_newRecMovie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_reccMovies);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_setImage);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_editName);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FriendForm";
            this.Text = "New Friend";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_editName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_FavGenre;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckedListBox genreCheckedList;
        private System.Windows.Forms.Button button_setImage;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ListBox listbox_reccMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_newRecMovie;
        private System.Windows.Forms.Button button_addMovie;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeMovieToolStripMenuItem3;
    }
}