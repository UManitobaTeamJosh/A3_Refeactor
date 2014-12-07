namespace A3Proj.TabPanels {
    partial class MovieTabPanel {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentParentTable = new System.Windows.Forms.TableLayoutPanel();
            this.movieFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.navButtonNext = new System.Windows.Forms.Button();
            this.navButtonPrev = new System.Windows.Forms.Button();
            this.labelPageOutOf = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pageSelectionBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillLabel0 = new System.Windows.Forms.Label();
            this.button_shortlistRemoveSel = new System.Windows.Forms.Button();
            this.searchTextBoxDirector = new System.Windows.Forms.TextBox();
            this.label_DirectorField = new System.Windows.Forms.Label();
            this.textBox_ActorQuery = new System.Windows.Forms.RichTextBox();
            this.genreCheckedList = new System.Windows.Forms.CheckedListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lengthToControl = new System.Windows.Forms.NumericUpDown();
            this.lengthFromControl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_shortlist = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.releaseToControl = new System.Windows.Forms.NumericUpDown();
            this.releaseFromControl = new System.Windows.Forms.NumericUpDown();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContentParentTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthToControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthFromControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseToControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseFromControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ContentParentTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 638);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ContentParentTable
            // 
            this.ContentParentTable.ColumnCount = 1;
            this.ContentParentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContentParentTable.Controls.Add(this.movieFlowPanel, 0, 1);
            this.ContentParentTable.Controls.Add(this.panel2, 0, 0);
            this.ContentParentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentParentTable.Location = new System.Drawing.Point(183, 3);
            this.ContentParentTable.Name = "ContentParentTable";
            this.ContentParentTable.RowCount = 2;
            this.ContentParentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.26257F));
            this.ContentParentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.73743F));
            this.ContentParentTable.Size = new System.Drawing.Size(569, 632);
            this.ContentParentTable.TabIndex = 5;
            // 
            // movieFlowPanel
            // 
            this.movieFlowPanel.AutoScroll = true;
            this.movieFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieFlowPanel.Location = new System.Drawing.Point(3, 48);
            this.movieFlowPanel.Name = "movieFlowPanel";
            this.movieFlowPanel.Size = new System.Drawing.Size(563, 581);
            this.movieFlowPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 39);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "database",
            "me",
            "both"});
            this.comboBox1.Location = new System.Drawing.Point(96, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Show ratings from: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.navButtonNext);
            this.panel3.Controls.Add(this.navButtonPrev);
            this.panel3.Controls.Add(this.labelPageOutOf);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pageSelectionBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(298, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 39);
            this.panel3.TabIndex = 7;
            // 
            // navButtonNext
            // 
            this.navButtonNext.Enabled = false;
            this.navButtonNext.Location = new System.Drawing.Point(228, 6);
            this.navButtonNext.Name = "navButtonNext";
            this.navButtonNext.Size = new System.Drawing.Size(34, 23);
            this.navButtonNext.TabIndex = 6;
            this.navButtonNext.Text = ">";
            this.navButtonNext.UseVisualStyleBackColor = true;
            this.navButtonNext.Click += new System.EventHandler(this.navButtonNext_Click);
            // 
            // navButtonPrev
            // 
            this.navButtonPrev.Enabled = false;
            this.navButtonPrev.Location = new System.Drawing.Point(188, 6);
            this.navButtonPrev.Name = "navButtonPrev";
            this.navButtonPrev.Size = new System.Drawing.Size(34, 23);
            this.navButtonPrev.TabIndex = 2;
            this.navButtonPrev.Text = "<";
            this.navButtonPrev.UseVisualStyleBackColor = true;
            this.navButtonPrev.Click += new System.EventHandler(this.navButtonPrev_Click);
            // 
            // labelPageOutOf
            // 
            this.labelPageOutOf.AutoSize = true;
            this.labelPageOutOf.Location = new System.Drawing.Point(102, 13);
            this.labelPageOutOf.Name = "labelPageOutOf";
            this.labelPageOutOf.Size = new System.Drawing.Size(43, 13);
            this.labelPageOutOf.TabIndex = 5;
            this.labelPageOutOf.Text = "out of 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Page #";
            // 
            // pageSelectionBox
            // 
            this.pageSelectionBox.Location = new System.Drawing.Point(52, 10);
            this.pageSelectionBox.Name = "pageSelectionBox";
            this.pageSelectionBox.Size = new System.Drawing.Size(44, 20);
            this.pageSelectionBox.TabIndex = 4;
            this.pageSelectionBox.Text = "1";
            this.pageSelectionBox.TextChanged += new System.EventHandler(this.pageSelectionBox_TextChanged);
            this.pageSelectionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageSelectionBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.fillLabel0);
            this.panel1.Controls.Add(this.button_shortlistRemoveSel);
            this.panel1.Controls.Add(this.searchTextBoxDirector);
            this.panel1.Controls.Add(this.label_DirectorField);
            this.panel1.Controls.Add(this.textBox_ActorQuery);
            this.panel1.Controls.Add(this.genreCheckedList);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lengthToControl);
            this.panel1.Controls.Add(this.lengthFromControl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listBox_shortlist);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.releaseToControl);
            this.panel1.Controls.Add(this.releaseFromControl);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 632);
            this.panel1.TabIndex = 4;
            // 
            // fillLabel0
            // 
            this.fillLabel0.AutoSize = true;
            this.fillLabel0.Location = new System.Drawing.Point(1, 437);
            this.fillLabel0.Name = "fillLabel0";
            this.fillLabel0.Size = new System.Drawing.Size(169, 13);
            this.fillLabel0.TabIndex = 29;
            this.fillLabel0.Text = "___________________________";
            // 
            // button_shortlistRemoveSel
            // 
            this.button_shortlistRemoveSel.Enabled = false;
            this.button_shortlistRemoveSel.Location = new System.Drawing.Point(82, 456);
            this.button_shortlistRemoveSel.Name = "button_shortlistRemoveSel";
            this.button_shortlistRemoveSel.Size = new System.Drawing.Size(75, 23);
            this.button_shortlistRemoveSel.TabIndex = 28;
            this.button_shortlistRemoveSel.Text = "Remove Selected";
            this.button_shortlistRemoveSel.UseVisualStyleBackColor = true;
            this.button_shortlistRemoveSel.Click += new System.EventHandler(this.button_shortlistRemoveSel_Click);
            // 
            // searchTextBoxDirector
            // 
            this.searchTextBoxDirector.Location = new System.Drawing.Point(11, 332);
            this.searchTextBoxDirector.Name = "searchTextBoxDirector";
            this.searchTextBoxDirector.Size = new System.Drawing.Size(153, 20);
            this.searchTextBoxDirector.TabIndex = 27;
            // 
            // label_DirectorField
            // 
            this.label_DirectorField.AutoSize = true;
            this.label_DirectorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DirectorField.Location = new System.Drawing.Point(9, 309);
            this.label_DirectorField.Name = "label_DirectorField";
            this.label_DirectorField.Size = new System.Drawing.Size(63, 16);
            this.label_DirectorField.TabIndex = 26;
            this.label_DirectorField.Text = "Director";
            // 
            // textBox_ActorQuery
            // 
            this.textBox_ActorQuery.Location = new System.Drawing.Point(12, 370);
            this.textBox_ActorQuery.Name = "textBox_ActorQuery";
            this.textBox_ActorQuery.Size = new System.Drawing.Size(145, 76);
            this.textBox_ActorQuery.TabIndex = 25;
            this.textBox_ActorQuery.Text = "";
            // 
            // genreCheckedList
            // 
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
            this.genreCheckedList.Location = new System.Drawing.Point(11, 211);
            this.genreCheckedList.Name = "genreCheckedList";
            this.genreCheckedList.ScrollAlwaysVisible = true;
            this.genreCheckedList.Size = new System.Drawing.Size(145, 94);
            this.genreCheckedList.TabIndex = 24;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(42, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "From";
            // 
            // lengthToControl
            // 
            this.lengthToControl.Location = new System.Drawing.Point(93, 147);
            this.lengthToControl.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.lengthToControl.Name = "lengthToControl";
            this.lengthToControl.Size = new System.Drawing.Size(64, 20);
            this.lengthToControl.TabIndex = 20;
            this.lengthToControl.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // lengthFromControl
            // 
            this.lengthFromControl.Location = new System.Drawing.Point(12, 147);
            this.lengthFromControl.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.lengthFromControl.Name = "lengthFromControl";
            this.lengthFromControl.Size = new System.Drawing.Size(64, 20);
            this.lengthFromControl.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Shortlist";
            // 
            // listBox_shortlist
            // 
            this.listBox_shortlist.AllowDrop = true;
            this.listBox_shortlist.FormattingEnabled = true;
            this.listBox_shortlist.Location = new System.Drawing.Point(15, 483);
            this.listBox_shortlist.Name = "listBox_shortlist";
            this.listBox_shortlist.Size = new System.Drawing.Size(144, 95);
            this.listBox_shortlist.TabIndex = 16;
            this.listBox_shortlist.SelectedIndexChanged += new System.EventHandler(this.shortlist_selIndChange);
            this.listBox_shortlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.shortlist_dragDrop);
            this.listBox_shortlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.shortlist_dragEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Actors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Release Year";
            // 
            // releaseToControl
            // 
            this.releaseToControl.Location = new System.Drawing.Point(92, 87);
            this.releaseToControl.Maximum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.releaseToControl.Name = "releaseToControl";
            this.releaseToControl.Size = new System.Drawing.Size(64, 20);
            this.releaseToControl.TabIndex = 2;
            this.releaseToControl.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // releaseFromControl
            // 
            this.releaseFromControl.Location = new System.Drawing.Point(13, 87);
            this.releaseFromControl.Maximum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.releaseFromControl.Name = "releaseFromControl";
            this.releaseFromControl.Size = new System.Drawing.Size(64, 20);
            this.releaseFromControl.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(158, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // MovieTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MovieTabPanel";
            this.Size = new System.Drawing.Size(755, 638);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContentParentTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthToControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthFromControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseToControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseFromControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel ContentParentTable;
        private System.Windows.Forms.FlowLayoutPanel movieFlowPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button navButtonNext;
        private System.Windows.Forms.Button navButtonPrev;
        private System.Windows.Forms.Label labelPageOutOf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pageSelectionBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fillLabel0;
        private System.Windows.Forms.Button button_shortlistRemoveSel;
        private System.Windows.Forms.TextBox searchTextBoxDirector;
        private System.Windows.Forms.Label label_DirectorField;
        private System.Windows.Forms.RichTextBox textBox_ActorQuery;
        private System.Windows.Forms.CheckedListBox genreCheckedList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown lengthToControl;
        private System.Windows.Forms.NumericUpDown lengthFromControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_shortlist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown releaseToControl;
        private System.Windows.Forms.NumericUpDown releaseFromControl;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;


    }
}
