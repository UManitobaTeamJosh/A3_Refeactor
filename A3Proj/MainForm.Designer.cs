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
            this.label1 = new System.Windows.Forms.Label();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.tabLists = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.movieTabPanel1 = new A3Proj.TabPanels.MovieTabPanel(movieData);
            this.friendsTabPanel1 = new A3Proj.TabPanels.FriendsTabPanel();
            this.tabControlMain.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.tabLists.SuspendLayout();
            this.tabFriends.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tabSettings.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(1104, 807);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1096, 774);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not in Prototype";
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.movieTabPanel1);
            this.tabMovies.Location = new System.Drawing.Point(4, 29);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(1127, 774);
            this.tabMovies.TabIndex = 1;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // tabLists
            // 
            this.tabLists.Controls.Add(this.label4);
            this.tabLists.Location = new System.Drawing.Point(4, 29);
            this.tabLists.Name = "tabLists";
            this.tabLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabLists.Size = new System.Drawing.Size(1127, 774);
            this.tabLists.TabIndex = 2;
            this.tabLists.Text = "Lists";
            this.tabLists.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Not in Prototype. See shortlist in Movies tab";
            // 
            // tabFriends
            // 
            this.tabFriends.Controls.Add(this.friendsTabPanel1);
            this.tabFriends.Location = new System.Drawing.Point(4, 29);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Size = new System.Drawing.Size(1127, 774);
            this.tabFriends.TabIndex = 3;
            this.tabFriends.Text = "Friends";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.label2);
            this.tabHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabHistory.Location = new System.Drawing.Point(4, 29);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(1127, 774);
            this.tabHistory.TabIndex = 4;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not in Prototype";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1127, 774);
            this.tabSettings.TabIndex = 5;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Not in Prototype";
            // 
            // movieTabPanel1
            // 
            this.movieTabPanel1.BackColor = System.Drawing.Color.White;
            this.movieTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieTabPanel1.Location = new System.Drawing.Point(3, 3);
            this.movieTabPanel1.Name = "movieTabPanel1";
            this.movieTabPanel1.Size = new System.Drawing.Size(1121, 768);
            this.movieTabPanel1.TabIndex = 1;
            // 
            // friendsTabPanel1
            // 
            this.friendsTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsTabPanel1.Location = new System.Drawing.Point(0, 0);
            this.friendsTabPanel1.Name = "friendsTabPanel1";
            this.friendsTabPanel1.Size = new System.Drawing.Size(1127, 774);
            this.friendsTabPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 807);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabMovies.ResumeLayout(false);
            this.tabLists.ResumeLayout(false);
            this.tabLists.PerformLayout();
            this.tabFriends.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
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
        private TabPanels.FriendsTabPanel friendsTabPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}