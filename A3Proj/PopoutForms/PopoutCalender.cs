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
