namespace A3Proj {
    partial class MainForm {
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.movieTabPanel1 = new A3Proj.TabPanels.MovieTabPanel(movieData);
            this.tabLists = new System.Windows.Forms.TabPage();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabHome);
            this.tabControlMain.Controls.Add(this.tabMovies);
            this.tabControlMain.Controls.Add(this.tabLists);
            this.tabControlMain.Controls.Add(this.tabFriends);
            this.tabControlMain.Controls.Add(this.tabHistory);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ItemSize = new System.Drawing.Size(50, 25);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(827, 642);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(819, 609);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.movieTabPanel1);
            this.tabMovies.Location = new System.Drawing.Point(4, 29);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(750, 558);
            this.tabMovies.TabIndex = 1;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // movieTabPanel1
            // 
            this.movieTabPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.movieTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieTabPanel1.Location = new System.Drawing.Point(3, 3);
            this.movieTabPanel1.Name = "movieTabPanel1";
            this.movieTabPanel1.Size = new System.Drawing.Size(744, 552);
            this.movieTabPanel1.TabIndex = 1;
            // 
            // tabLists
            // 
            this.tabLists.Location = new System.Drawing.Point(4, 29);
            this.tabLists.Name = "tabLists";
            this.tabLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabLists.Size = new System.Drawing.Size(750, 558);
            this.tabLists.TabIndex = 2;
            this.tabLists.Text = "Lists";
            this.tabLists.UseVisualStyleBackColor = true;
            // 
            // tabFriends
            // 
            this.tabFriends.Location = new System.Drawing.Point(4, 29);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Size = new System.Drawing.Size(750, 558);
            this.tabFriends.TabIndex = 3;
            this.tabFriends.Text = "Friends";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            this.tabHistory.Location = new System.Drawing.Point(4, 29);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(750, 558);
            this.tabHistory.TabIndex = 4;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(750, 558);
            this.tabSettings.TabIndex = 5;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 642);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabLists;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabSettings;
        private TabPanels.MovieTabPanel movieTabPanel1;
    }
}