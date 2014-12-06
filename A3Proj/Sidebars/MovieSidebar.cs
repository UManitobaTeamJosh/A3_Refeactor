using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *  You were implementing the movie sidebar
 */
namespace A3Proj.TabPanels {
    public partial class MovieSidebar : A3Proj.Sidebar {
        public MovieSidebar() {
            InitializeComponent();
        }

        public CheckedListBox getGenreBox() {
            return genreCheckedList;
        }

        public String getQuery() {
            return searchTextBox.Text;
        }

        public int getYearFrom() {
            return (int)releaseFromControl.Value;
        }

        public int getYearTo() {
            return (int)releaseToControl.Value;
        }

        public int getLengthFrom() {
            return (int)lengthFromControl.Value;
        }

        public int getLengthTo() {
            return (int)lengthToControl.Value;
        }
    }
}
