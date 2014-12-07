using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj {
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     * The main body of the program.
     * The program's MovieData is stored here.
     */
    public partial class MainForm : Form {

        private static readonly int tabScalePadding = 19;
        private MovieData movieData;

        public MainForm() {
            movieData = new MovieData();
            //
            InitializeComponent();
            //Autosize tabs
            int height = tabControlMain.ItemSize.Height;
            int numTabs = tabControlMain.TabPages.Count;
            tabControlMain.ItemSize = new Size((this.Size.Width - 19) / numTabs, height);
            //Data
        }

        /*
         *  On a resize event, scale the tabs width so they fill the form.
         *  Uses tabScalePadding so that the scrolling option does not appear.
         */
        private void resize(object sender, EventArgs e) {
            Control control = (Control)sender;
            int height = tabControlMain.ItemSize.Height;
            int numTabs = tabControlMain.TabPages.Count;
            tabControlMain.ItemSize = new Size((control.Size.Width-tabScalePadding)/numTabs,height);
        }
    }
}
