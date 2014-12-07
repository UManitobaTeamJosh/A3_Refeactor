namespace A3Proj.PopoutForms {
    partial class MovieForm {
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
            this.label_MovieTitle = new System.Windows.Forms.Label();
            this.label_basicMovieInfo = new System.Windows.Forms.Label();
            this.button_AddShortlist = new System.Windows.Forms.Button();
            this.label_DirectorActor = new System.Windows.Forms.Label();
            this.comboBox_Rating = new System.Windows.Forms.ComboBox();
            this.label_YourReview = new System.Windows.Forms.Label();
            this.richTextBox_Review = new System.Windows.Forms.RichTextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_rating = new System.Windows.Forms.Label();
            this.label_NegRating = new System.Windows.Forms.Label();
            this.radio_not = new System.Windows.Forms.RadioButton();
            this.radio_on = new System.Windows.Forms.RadioButton();
            this.label_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MovieTitle
            // 
            this.label_MovieTitle.AutoEllipsis = true;
            this.label_MovieTitle.AutoSize = true;
            this.label_MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MovieTitle.Location = new System.Drawing.Point(175, 12);
            this.label_MovieTitle.Name = "label_MovieTitle";
            this.label_MovieTitle.Size = new System.Drawing.Size(199, 25);
            this.label_MovieTitle.TabIndex = 1;
            this.label_MovieTitle.Text = "%MOVIE_TITLE%";
            // 
            // label_basicMovieInfo
            // 
            this.label_basicMovieInfo.AutoSize = true;
            this.label_basicMovieInfo.Location = new System.Drawing.Point(180, 61);
            this.label_basicMovieInfo.Name = "label_basicMovieInfo";
            this.label_basicMovieInfo.Size = new System.Drawing.Size(272, 13);
            this.label_basicMovieInfo.TabIndex = 2;
            this.label_basicMovieInfo.Text = "### mins - GENRE, GENRE - %day% %month% %year%";
            // 
            // button_AddShortlist
            // 
            this.button_AddShortlist.Location = new System.Drawing.Point(12, 247);
            this.button_AddShortlist.Name = "button_AddShortlist";
            this.button_AddShortlist.Size = new System.Drawing.Size(157, 23);
            this.button_AddShortlist.TabIndex = 3;
            this.button_AddShortlist.Text = "Add to Shortlist";
            this.button_AddShortlist.UseVisualStyleBackColor = true;
            this.button_AddShortlist.Click += new System.EventHandler(this.button_AddShortlist_Click);
            // 
            // label_DirectorActor
            // 
            this.label_DirectorActor.AutoSize = true;
            this.label_DirectorActor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_DirectorActor.Location = new System.Drawing.Point(180, 84);
            this.label_DirectorActor.Name = "label_DirectorActor";
            this.label_DirectorActor.Size = new System.Drawing.Size(47, 13);
            this.label_DirectorActor.TabIndex = 4;
            this.label_DirectorActor.Text = "Director:";
            // 
            // comboBox_Rating
            // 
            this.comboBox_Rating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Rating.FormattingEnabled = true;
            this.comboBox_Rating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_Rating.Location = new System.Drawing.Point(442, 381);
            this.comboBox_Rating.Name = "comboBox_Rating";
            this.comboBox_Rating.Size = new System.Drawing.Size(50, 21);
            this.comboBox_Rating.TabIndex = 5;
            // 
            // label_YourReview
            // 
            this.label_YourReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_YourReview.AutoSize = true;
            this.label_YourReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YourReview.Location = new System.Drawing.Point(52, 376);
            this.label_YourReview.Name = "label_YourReview";
            this.label_YourReview.Size = new System.Drawing.Size(117, 24);
            this.label_YourReview.TabIndex = 6;
            this.label_YourReview.Text = "Your Review";
            // 
            // richTextBox_Review
            // 
            this.richTextBox_Review.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Review.Location = new System.Drawing.Point(13, 405);
            this.richTextBox_Review.Name = "richTextBox_Review";
            this.richTextBox_Review.Size = new System.Drawing.Size(522, 218);
            this.richTextBox_Review.TabIndex = 7;
            this.richTextBox_Review.Text = "";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(460, 629);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(373, 629);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "/10";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Your Rating:";
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rating.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_rating.Location = new System.Drawing.Point(176, 42);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(85, 20);
            this.label_rating.TabIndex = 12;
            this.label_rating.Text = "%rating%";
            // 
            // label_NegRating
            // 
            this.label_NegRating.AutoSize = true;
            this.label_NegRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NegRating.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_NegRating.Location = new System.Drawing.Point(267, 42);
            this.label_NegRating.Name = "label_NegRating";
            this.label_NegRating.Size = new System.Drawing.Size(85, 20);
            this.label_NegRating.TabIndex = 13;
            this.label_NegRating.Text = "%rating%";
            // 
            // radio_not
            // 
            this.radio_not.AutoSize = true;
            this.radio_not.Location = new System.Drawing.Point(342, 292);
            this.radio_not.Name = "radio_not";
            this.radio_not.Size = new System.Drawing.Size(89, 17);
            this.radio_not.TabIndex = 14;
            this.radio_not.TabStop = true;
            this.radio_not.Text = "Not Watched";
            this.radio_not.UseVisualStyleBackColor = true;
            this.radio_not.CheckedChanged += new System.EventHandler(this.NotWatchedChange);
            // 
            // radio_on
            // 
            this.radio_on.AutoSize = true;
            this.radio_on.Location = new System.Drawing.Point(342, 324);
            this.radio_on.Name = "radio_on";
            this.radio_on.Size = new System.Drawing.Size(84, 17);
            this.radio_on.TabIndex = 15;
            this.radio_on.TabStop = true;
            this.radio_on.Text = "Watched on";
            this.radio_on.UseVisualStyleBackColor = true;
            this.radio_on.CheckedChanged += new System.EventHandler(this.watchOnChange);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(432, 323);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(66, 18);
            this.label_date.TabIndex = 16;
            this.label_date.Text = "xx/xx/xxxx";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::A3Proj.Properties.Resources.calenderIcon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(506, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MoviePosterPictureBox
            // 
            this.MoviePosterPictureBox.Image = global::A3Proj.Properties.Resources.placeholder_movie;
            this.MoviePosterPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MoviePosterPictureBox.Name = "MoviePosterPictureBox";
            this.MoviePosterPictureBox.Size = new System.Drawing.Size(157, 228);
            this.MoviePosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePosterPictureBox.TabIndex = 0;
            this.MoviePosterPictureBox.TabStop = false;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.radio_on);
            this.Controls.Add(this.radio_not);
            this.Controls.Add(this.label_NegRating);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.richTextBox_Review);
            this.Controls.Add(this.label_YourReview);
            this.Controls.Add(this.comboBox_Rating);
            this.Controls.Add(this.label_DirectorActor);
            this.Controls.Add(this.button_AddShortlist);
            this.Controls.Add(this.label_basicMovieInfo);
            this.Controls.Add(this.label_MovieTitle);
            this.Controls.Add(this.MoviePosterPictureBox);
            this.Name = "MovieForm";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePosterPictureBox;
        private System.Windows.Forms.Label label_MovieTitle;
        private System.Windows.Forms.Label label_basicMovieInfo;
        private System.Windows.Forms.Button button_AddShortlist;
        private System.Windows.Forms.Label label_DirectorActor;
        private System.Windows.Forms.ComboBox comboBox_Rating;
        private System.Windows.Forms.Label label_YourReview;
        private System.Windows.Forms.RichTextBox richTextBox_Review;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.Label label_NegRating;
        private System.Windows.Forms.RadioButton radio_not;
        private System.Windows.Forms.RadioButton radio_on;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}