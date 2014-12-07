using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj.TabPanels {
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     *  Parent class for all tab panels.
     *  Currently used to allow child forms to inherit a tooltip.
     *  
     *  Could hold colors that the child forms can reference (having a common sidebar color...etc)
     *  (Color spelt with American spelling since the object is spelt that way...)
     */
    public partial class TabPanel : UserControl {

        public static Color red = Color.FromArgb(255, 255, 0, 0);

        public TabPanel() {
            InitializeComponent();
        }
    }
}
