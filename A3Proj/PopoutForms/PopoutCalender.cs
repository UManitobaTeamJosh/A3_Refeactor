using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj.PopoutForms {
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     * Small form to support MovieForm. Used to select a date.
     * When the user clicks on "Select Date" that choice is sent back to the
     * parent MovieForm.
     */
    public partial class PopoutCalender : Form {

        private MovieForm parent;

        public PopoutCalender(MovieForm parent) {
            InitializeComponent();
            this.parent = parent;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            parent.sendDate(monthCalendar1.SelectionRange.Start.ToShortDateString());
            this.Close();
        }
    }
}
