using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace A3Proj.TabPanels{
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     * The panel for the Movies tab.
     */
    public partial class MovieTabPanel : A3Proj.TabPanels.TabPanel {

        private static readonly int MOVIE_PAGE_CAPACITY = 50;
        private static readonly String SHORTLIST_FILE = "shortList.xml";

        private MovieData movieData;
        private List<String> shortList;
        private List<List<Movie>> moviePageList;

        public MovieTabPanel() {
            InitializeComponent();
            shortList = new List<String>();
            loadShortList();
        }

        public MovieTabPanel(MovieData mData) :this() {
            movieData = mData;
            performSearch();
            comboBox1.SelectedIndex = 0;
        }

        /*
         *  Allows a Movie to be updated. Stores the current page so that
         *  after the update, the user is sent back to where they were before
         *  they edited the movie.
         */
        public void updateMovie(Movie newMovie) {
            int currentPage = Convert.ToInt32(pageSelectionBox.Text);
            movieData.updateMovie(newMovie);
            performSearch();
            pageSelectionBox.Text = currentPage.ToString();
            populateTable();
            updateNavButtons();
        }

        /*
         * Opens a MovieForm with the given Movie object.
         */
        public void openMovieForm(Movie movie) {
            A3Proj.PopoutForms.MovieForm movieForm = new A3Proj.PopoutForms.MovieForm(movie,this);
            movieForm.ShowDialog();
        }

        /*
         *  Allows PopoutForms to add movies to the shortlsit.
         */
        public void addMovieToShortlist(Movie movie) {
            pushToShortlist(movie.getTitle());
        }

        /*
         *  Populate the current page with the relevant movie data.
         */
        private void populateTable() {
            movieFlowPanel.Controls.Clear();
            int currentPageNumber = Convert.ToInt32(pageSelectionBox.Text) - 1;
            if (currentPageNumber < moviePageList.Count) {
                List<Movie> currentPage = moviePageList[currentPageNumber];
                foreach (Movie movie in currentPage) {
                    MovieBox newMovieBox = new MovieBox(movie, this, comboBox1.SelectedIndex);
                    movieFlowPanel.Controls.Add(newMovieBox);
                }
            }
        }

        /*
         *  Using queries gathered from the user search controls, produces
         *  a query then populates the flow table with the result.
         *  Navigation buttons are updated as appropriately to match the number of pages.
         */
        private void performSearch() {
            String searchQuery = searchTextBox.Text;
            String directorQuery = searchTextBoxDirector.Text;
            String[] actorsQuery = getSearchActors();
            int yearFrom = (int)releaseFromControl.Value;
            int yearTo = (int)releaseToControl.Value;
            int lengthFrom = (int)lengthFromControl.Value;
            int lengthTo = (int)lengthToControl.Value;
            moviePageList = movieData.produceQuery(MOVIE_PAGE_CAPACITY, genreCheckedList,searchQuery,actorsQuery,directorQuery, yearFrom, yearTo, lengthFrom, lengthTo);
            pageSelectionBox.Text = "1";
            labelPageOutOf.Text = "out of " + moviePageList.Count();
            updateNavButtons();
            populateTable();
        }

        /*
         *  Returns an array of the actors in the corresponding text box.
         *  Separates actors by commas.
         */
        private String[] getSearchActors() {
            String boxText = textBox_ActorQuery.Text;
            String[] actors = new String[1];
            if (boxText.Length > 0) {
                actors = boxText.Split(',');
                for (int i = 0; i < actors.Length; i++) {
                    actors[i] = actors[i].Trim();
                }
           }
            return actors;
        }

        //Adds item to shortList and updates the listBox
        private void pushToShortlist(String movieTitle) {
            shortList.Add(movieTitle);
            listBox_shortlist.Items.Clear();
            foreach(String movie in shortList){
                listBox_shortlist.Items.Add(movie);
            }
            saveShortList();
        }

        /*
         *  Loads the shortList from an XML file.
         */
        private void loadShortList() {
            if (System.IO.File.Exists(SHORTLIST_FILE)) {
                XDocument xmlSource = XDocument.Load(SHORTLIST_FILE);
                IEnumerable<XElement> items = xmlSource.Descendants("movieTitle");
                shortList.Clear();
                listBox_shortlist.Items.Clear();
                foreach (var p in items) {
                    shortList.Add(p.Value);
                }
                foreach (String movieTitle in shortList) {
                    listBox_shortlist.Items.Add(movieTitle);
                }
            }
        }

        /*
         *  Saves the shortList to an XML file.
         */
        private void saveShortList() {
            XDocument xdoc = new XDocument(new XElement("movieList"));
            foreach (String movieTitle in shortList) {
                xdoc.Element("movieList").Add(new XElement("movieTitle", movieTitle));
            }
            xdoc.Save(SHORTLIST_FILE);
        }

        /*
         *  Makes nav buttons update to reflect the page number.
         *  If we're already on the first page, then prev should be disabled.
         *  If prev is disabled and we're no longer on the first page, it should be enabled. 
         *  Etc.
         */
        private void updateNavButtons() {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            navButtonPrev.Enabled = !(pageNumber == 1);
            navButtonNext.Enabled = !(pageNumber == moviePageList.Count());
        }

        /*
         *  Display the previous page of movies.
         */
        private void navButtonPrev_Click(object sender, EventArgs e) {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            pageNumber--;
            if (pageNumber <= 1) {
                pageNumber = 1;
            }
            pageSelectionBox.Text = pageNumber.ToString();
            updateNavButtons();
        }

        /*
         *  Display the next movie page.
         */
        private void navButtonNext_Click(object sender, EventArgs e) {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            pageNumber++;
            if (pageNumber >= moviePageList.Count()) {
                pageNumber = moviePageList.Count();
            }
            pageSelectionBox.Text = pageNumber.ToString();
            updateNavButtons();
        }

        /*
         *  Ensures the user can't input any out of bounds numbers.
         */
        private void pageSelectionBox_TextChanged(object sender, EventArgs e) {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            if (pageNumber > moviePageList.Count()) {
                pageSelectionBox.Text = moviePageList.Count().ToString();
            }
            populateTable();
            updateNavButtons();
        }

        /*
         *  The page selection box should only allow numbers and control keys.
         */
        private void pageSelectionBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        /*
         *  To allow the user to perform movie searches.
         */
        private void buttonSearch_Click(object sender, EventArgs e) {
            performSearch();
        }

        /*
         *  For dragging movies onto the shortList.
         */
        private void shortlist_dragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        /*
         *  For dragging movies onto the shortList
         */
        private void shortlist_dragDrop(object sender, DragEventArgs e) {
            String newTitle = e.Data.GetData(DataFormats.StringFormat).ToString();
            pushToShortlist(newTitle);
        }

        /*
         *  Removes the item at the selectedIndex from the shortList
         */
        private void button_shortlistRemoveSel_Click(object sender, EventArgs e) {
            int selIndex = listBox_shortlist.SelectedIndex;
            if (selIndex > -1) {
                listBox_shortlist.Items.RemoveAt(selIndex);
                shortList.RemoveAt(selIndex);
                saveShortList();
            }
            button_shortlistRemoveSel.Enabled = false;
        }

        /*
         *  When an item is selected, indicate to the user it can be deleted by enabling the
         *  remove button.
         */
        private void shortlist_selIndChange(object sender, EventArgs e) {
            button_shortlistRemoveSel.Enabled = true;
        }

        /*
         *  Whenever the Ratings mode combobox changes, update the MovieBoxes appropriately
         */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            populateTable();
        }

        

    }
}
