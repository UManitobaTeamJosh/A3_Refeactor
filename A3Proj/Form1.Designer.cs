namespace A3Proj {
    
    partial class Form1 {
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pageSelectionBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPageOutOf = new System.Windows.Forms.Label();
            this.navButtonPrev = new System.Windows.Forms.Button();
            this.navButtonNext = new System.Windows.Forms.Button();
            this.movieFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentParentTable = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.releaseFromControl = new System.Windows.Forms.NumericUpDown();
            this.releaseToControl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lengthFromControl = new System.Windows.Forms.NumericUpDown();
            this.lengthToControl = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.genreCheckedList = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ContentParentTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.releaseFromControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseToControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthFromControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthToControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Controls.Add(this.tabPage5);
            this.Tabs.Controls.Add(this.tabPage6);
            this.Tabs.ItemSize = new System.Drawing.Size(200, 40);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(965, 591);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(43, 33);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.ContentParentTable);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(957, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lists";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(957, 543);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Friends";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(957, 543);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "History";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Silver;
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(957, 543);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(523, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.navButtonNext);
            this.panel3.Controls.Add(this.navButtonPrev);
            this.panel3.Controls.Add(this.labelPageOutOf);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pageSelectionBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(513, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 33);
            this.panel3.TabIndex = 7;
            // 
            // pageSelectionBox
            // 
            this.pageSelectionBox.Location = new System.Drawing.Point(52, 5);
            this.pageSelectionBox.Name = "pageSelectionBox";
            this.pageSelectionBox.Size = new System.Drawing.Size(44, 20);
            this.pageSelectionBox.TabIndex = 4;
            this.pageSelectionBox.Text = "1";
            this.pageSelectionBox.TextChanged += new System.EventHandler(this.pageSelectionBox_TextChanged);
            this.pageSelectionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageSelectionBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Page #";
            // 
            // labelPageOutOf
            // 
            this.labelPageOutOf.AutoSize = true;
            this.labelPageOutOf.Location = new System.Drawing.Point(102, 8);
            this.labelPageOutOf.Name = "labelPageOutOf";
            this.labelPageOutOf.Size = new System.Drawing.Size(34, 13);
            this.labelPageOutOf.TabIndex = 5;
            this.labelPageOutOf.Text = "out of";
            // 
            // navButtonPrev
            // 
            this.navButtonPrev.Location = new System.Drawing.Point(188, 1);
            this.navButtonPrev.Name = "navButtonPrev";
            this.navButtonPrev.Size = new System.Drawing.Size(34, 23);
            this.navButtonPrev.TabIndex = 2;
            this.navButtonPrev.Text = "<";
            this.toolTip1.SetToolTip(this.navButtonPrev, "Previous page");
            this.navButtonPrev.UseVisualStyleBackColor = true;
            this.navButtonPrev.Click += new System.EventHandler(this.navButtonPrev_Click);
            // 
            // navButtonNext
            // 
            this.navButtonNext.Location = new System.Drawing.Point(228, 1);
            this.navButtonNext.Name = "navButtonNext";
            this.navButtonNext.Size = new System.Drawing.Size(34, 23);
            this.navButtonNext.TabIndex = 6;
            this.navButtonNext.Text = ">";
            this.toolTip1.SetToolTip(this.navButtonNext, "Next page");
            this.navButtonNext.UseVisualStyleBackColor = true;
            this.navButtonNext.Click += new System.EventHandler(this.button4_Click);
            // 
            // movieFlowPanel
            // 
            this.movieFlowPanel.AutoScroll = true;
            this.movieFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieFlowPanel.Location = new System.Drawing.Point(3, 42);
            this.movieFlowPanel.Name = "movieFlowPanel";
            this.movieFlowPanel.Size = new System.Drawing.Size(778, 492);
            this.movieFlowPanel.TabIndex = 0;
            // 
            // ContentParentTable
            // 
            this.ContentParentTable.ColumnCount = 1;
            this.ContentParentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContentParentTable.Controls.Add(this.movieFlowPanel, 0, 1);
            this.ContentParentTable.Controls.Add(this.panel2, 0, 0);
            this.ContentParentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentParentTable.Location = new System.Drawing.Point(170, 3);
            this.ContentParentTable.Name = "ContentParentTable";
            this.ContentParentTable.RowCount = 2;
            this.ContentParentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.26257F));
            this.ContentParentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.73743F));
            this.ContentParentTable.Size = new System.Drawing.Size(784, 537);
            this.ContentParentTable.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(158, 20);
            this.searchTextBox.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Actors";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(14, 367);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 19);
            this.checkedListBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 442);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Shortlist";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "From";
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
            this.genreCheckedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.genreCheckedList_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.genreCheckedList);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lengthToControl);
            this.panel1.Controls.Add(this.lengthFromControl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.releaseToControl);
            this.panel1.Controls.Add(this.releaseFromControl);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 537);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 593);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ContentParentTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.releaseFromControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseToControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthFromControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthToControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.CheckedListBox genreCheckedList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown lengthToControl;
        private System.Windows.Forms.NumericUpDown lengthFromControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown releaseToControl;
        private System.Windows.Forms.NumericUpDown releaseFromControl;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

