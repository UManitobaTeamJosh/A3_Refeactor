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
            this.label_MovieTitle.Size = new System.Drawing.Size(159, 25);
            this.label_MovieTitle.TabIndex = 1;
            this.label_MovieTitle.Text = "MOVIE_TITLE";
            // 
            // label_basicMovieInfo
            // 
            this.label_basicMovieInfo.AutoSize = true;
            this.label_basicMovieInfo.Location = new System.Drawing.Point(180, 41);
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
            this.label_DirectorActor.Location = new System.Drawing.Point(180, 64);
            this.label_DirectorActor.Name = "label_DirectorActor";
            this.label_DirectorActor.Size = new System.Drawing.Size(47, 13);
            this.label_DirectorActor.TabIndex = 4;
            this.label_DirectorActor.Text = "Director:";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 409);
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
    }
}