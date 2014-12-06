namespace A3Proj {
    partial class MovieBox {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieBox));
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.labelMovieYear = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToShortlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(2, 166);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(27, 13);
            this.labelMovieTitle.TabIndex = 0;
            this.labelMovieTitle.Text = "Title";
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.movieImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieImage.BackgroundImage")));
            this.movieImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movieImage.Location = new System.Drawing.Point(2, 2);
            this.movieImage.Margin = new System.Windows.Forms.Padding(2);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(140, 161);
            this.movieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieImage.TabIndex = 1;
            this.movieImage.TabStop = false;
            // 
            // labelMovieYear
            // 
            this.labelMovieYear.AutoSize = true;
            this.labelMovieYear.Location = new System.Drawing.Point(4, 183);
            this.labelMovieYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovieYear.Name = "labelMovieYear";
            this.labelMovieYear.Size = new System.Drawing.Size(35, 13);
            this.labelMovieYear.TabIndex = 2;
            this.labelMovieYear.Text = "####";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.addToShortlistToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openToolStripMenuItem.Text = "View movie info";
            // 
            // addToShortlistToolStripMenuItem
            // 
            this.addToShortlistToolStripMenuItem.Name = "addToShortlistToolStripMenuItem";
            this.addToShortlistToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToShortlistToolStripMenuItem.Text = "Add to shortlist";
            // 
            // MovieBox
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMovieYear);
            this.Controls.Add(this.movieImage);
            this.Controls.Add(this.labelMovieTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovieBox";
            this.Size = new System.Drawing.Size(143, 224);
            this.Load += new System.EventHandler(this.MovieBox_Load);
            this.Click += new System.EventHandler(this.click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dradDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragStart);
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.PictureBox movieImage;
        private System.Windows.Forms.Label labelMovieYear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToShortlistToolStripMenuItem;

    }
}
