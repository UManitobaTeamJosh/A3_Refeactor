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
     *  Parent class for all tab panels.
     *  
     *  Presently only used to store common color data.
     *  (Color spelt with American spelling since the object is spelt that way...)
     */
    public partial class TabPanel : UserControl {

        public static Color red = Color.FromArgb(255, 255, 0, 0);

        public TabPanel() {
            InitializeComponent();
        }
    }
}
