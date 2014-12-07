using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

/*
 *  Old code, from before the refactor. Kept for reference.
 */
namespace A3Proj {
    public partial class Form1 : Form {

        private static readonly String FILE_NAME = "movies.xml";
        private List<Movie> movieList = new List<Movie>();

        private List<List<Movie>> moviePageList;
        private int pageTableCapacity = 50; //arbitrarily selected number.

        public Form1() {
            InitializeComponent();
            loadXML();
            performSearch();
        }
        
        /*
         *  Saves the contents of movieList to an XML document. Should the the same file
         *  from which the database is loaded.
         *  
         *  NOTE: Currently outputting to a TEST_OUTPUT.xml file.
         */
        private void saveDataToXML() {
            XDocument xdoc = new XDocument(new XElement("movielist"));
            foreach(Movie movie in movieList){
                XElement root = new XElement("movie");
                root.Add(new XElement("title",movie.getTitle()));
                root.Add(new XElement("year", movie.getYear()));
                root.Add(new XElement("length", movie.getLength()));
                //certification
                root.Add(new XElement("director", movie.getDirector()));
                root.Add(new XElement("rating", movie.getRating()));
                String[] genreList = movie.getGenres();
                for (int i = 0; i < genreList.Length; i++) {
                    root.Add(new XElement("genre", genreList[i]));
                }
                String[] actorList = movie.getActors();
                for (int i = 0; i < actorList.Length; i++) {
                    root.Add(new XElement("actor", actorList[i]));
                }
                xdoc.Element("movielist").Add(root);
            }
            xdoc.Save("TEST_OUTPUT.xml");
            MessageBox.Show("File saved to TEST_OUTPUT.xml");
        }


        private void performSearch() {
            String searchQuery = searchTextBox.Text;
            int yearFrom = (int)releaseFromControl.Value;
            int yearTo = (int)releaseToControl.Value;
            int lengthFrom = (int)lengthFromControl.Value;
            int lengthTo = (int)lengthToControl.Value;
            moviePageList = produceQuery(searchQuery, yearFrom, yearTo, lengthFrom, lengthTo);
            /*
            Console.WriteLine("QUERY <"+searchQuery+">");
            Console.WriteLine("YEAR FROM: "+yearFrom+"\tYEAR TO: "+yearTo);
            Console.WriteLine("LENG FROM: " + lengthFrom + "\tLENG TO: " + lengthTo);
            Console.WriteLine("SEARCH RESULTS -------------------");
            foreach(List<Movie> page in moviePageList){
                foreach (Movie movie in page) {
                    Console.WriteLine(movie.toString());
                }
            }
            */
            pageSelectionBox.Text = "1";
            labelPageOutOf.Text = "out of " + moviePageList.Count();
            updateNavButtons();
            populateTable();
        }

        private List<List<Movie>> produceQuery(String searchQuery, int yearFrom, int yearTo, int lengthFrom, int lengthTo) {
            List<List<Movie>> pageList = new List<List<Movie>>();
            List<Movie> page = new List<Movie>();

            //Get the selected genres
            List<string> selectedGenreList = new List<string>();
            foreach (Object item in genreCheckedList.CheckedItems) {
                selectedGenreList.Add(item.ToString());
            }
            /*
            Console.WriteLine("--Genres Selected--");
            foreach (string word in selectedGenreList) {
                Console.WriteLine(word);
            }
            */
            //Quick 'n' dirty implementation, itereate through each movie in the database.
            foreach (Movie movie in movieList) {
                if (movie.getYear() >= yearFrom && movie.getYear() <= yearTo 
                    && movie.getLength() >= lengthFrom && movie.getLength() <= lengthTo
                    && movie.genreMatch(selectedGenreList)) {
                    if (!String.IsNullOrWhiteSpace(searchQuery) && movie.getTitle().Contains(searchQuery)) {
                        page.Add(movie);
                    } else if(String.IsNullOrWhiteSpace(searchQuery)){
                        //No search query specefied. Do not filter on search.
                        page.Add(movie);
                    }
                }
                if (page.Count >= pageTableCapacity) {
                    pageList.Add(page);
                    page = new List<Movie>();
                }
            }
            pageList.Add(page);
            return pageList;
        }

        /*
         *  Populate the current page with the relevant movie data.
         */
        private void populateTable() {
            movieFlowPanel.Controls.Clear();
            int currentPageNumber = Convert.ToInt32(pageSelectionBox.Text)-1;
            if (currentPageNumber < moviePageList.Count) {
                List<Movie> currentPage = moviePageList[currentPageNumber];
                foreach (Movie movie in currentPage) {
                    //movieFlowPanel.Controls.Add(new MovieBox(movie,this));
                }
            }
        }

        private void loadXML() {
            if (System.IO.File.Exists(FILE_NAME)) {
                XDocument xmlSource = XDocument.Load(FILE_NAME);
                IEnumerable<XElement> items = xmlSource.Descendants("movie");
                List<Movie> movieList = new List<Movie>();
                foreach (var p in items) {
                    IEnumerable<XElement> elementItems = p.Descendants();
                    int eIndex = 0;
                    String name = null;
                    int year = -1;
                    int length = -1;
                    //certification
                    String director = null;
                    int rating = -1;
                    List<string> genres = new List<string>();
                    List<string> actors = new List<string>();
                    foreach (var p2 in elementItems) {
                        String elementName = p2.Name.ToString();
                        //Console.WriteLine(eIndex+" - "+elementName+"\t-\t"+p2.Value);
                        switch (elementName) {
                            case "title":
                                name = p2.Value;
                                break;
                            case "year":
                                year = Convert.ToInt32(p2.Value);
                                break;
                            case "length":
                                length = parseLength(p2.Value);
                                break;
                            case "certification":
                                //Unused
                                break;
                            case "director":
                                director = p2.Value;
                                break;
                            case "rating":
                                rating = Convert.ToInt32(p2.Value);
                                break;
                            case "genre":
                                genres.Add(p2.Value);
                                break;
                            case "actor":
                                actors.Add(p2.Value);
                                break;
                        }
                        eIndex++;
                    }//foreach subelement
                    //Movie movie = new Movie(name, year, length, director, rating, genres, actors);
                   // movieList.Add(movie);
                }//foreach descendant
                //Done loading movies. Do something with movielist now.
                /*
                foreach (Movie movie in movieList) {
                    Console.WriteLine(movie.toString());
                }
                */
                this.movieList = movieList;
            } else {
                MessageBox.Show("xmlSource.xml not found. No data loaded.");
            }
            //Do something with data, like populate a table
        }

        private int parseLength(string input) {
            int length = -1;
            string[] token = input.Split(null);
            if (token.Length > 0) {
                length = Convert.ToInt32(token[0]);
            }
            return length;
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

        private void saveButton_Click(object sender, EventArgs e) {
            saveDataToXML();
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            performSearch();
        }

        private void navButtonPrev_Click(object sender, EventArgs e) {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            pageNumber--;
            if (pageNumber <= 1) {
                pageNumber = 1;
            }
            pageSelectionBox.Text = pageNumber.ToString();
            updateNavButtons();
        }

        private void button4_Click(object sender, EventArgs e) {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            pageNumber++;
            if (pageNumber >= moviePageList.Count()) {
                pageNumber = moviePageList.Count();
            }
            pageSelectionBox.Text = pageNumber.ToString();
            updateNavButtons();
        }

        private void pageSelectionBox_TextChanged(object sender, EventArgs e) {
            int pageNumber = Convert.ToInt32(pageSelectionBox.Text);
            if (pageNumber > moviePageList.Count()) {
                pageSelectionBox.Text = moviePageList.Count().ToString();
            } 
            populateTable();
            updateNavButtons();
        }

        private void pageSelectionBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        //TODO Remove
        private void genreCheckedList_ItemCheck(object sender, ItemCheckEventArgs e) {
        }

    }
}
