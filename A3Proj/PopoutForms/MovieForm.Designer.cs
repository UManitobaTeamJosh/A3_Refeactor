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
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.comboBox_Rating.Location = new System.Drawing.Point(391, 277);
            this.comboBox_Rating.Name = "comboBox_Rating";
            this.comboBox_Rating.Size = new System.Drawing.Size(50, 21);
            this.comboBox_Rating.TabIndex = 5;
            // 
            // label_YourReview
            // 
            this.label_YourReview.AutoSize = true;
            this.label_YourReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YourReview.Location = new System.Drawing.Point(8, 273);
            this.label_YourReview.Name = "label_YourReview";
            this.label_YourReview.Size = new System.Drawing.Size(117, 24);
            this.label_YourReview.TabIndex = 6;
            this.label_YourReview.Text = "Your Review";
            // 
            // richTextBox_Review
            // 
            this.richTextBox_Review.Location = new System.Drawing.Point(13, 301);
            this.richTextBox_Review.Name = "richTextBox_Review";
            this.richTextBox_Review.Size = new System.Drawing.Size(471, 218);
            this.richTextBox_Review.TabIndex = 7;
            this.richTextBox_Review.Text = "";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(409, 525);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(322, 525);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "/10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 276);
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
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 560);
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
    }
}