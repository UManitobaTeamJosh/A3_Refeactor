using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace A3Proj {
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     *  MovieData represents a body of movies. It's used to load, save, and access the
     *  movies stored in the XML database.
     */
    public class MovieData {

        private static readonly String FILE_NAME = "movies.xml";
        private List<Movie> movieList;

        public MovieData() {
            movieList = new List<Movie>();
            loadXML();
        }

        /*
         *  Updates a Movie with another Movie.
         *  
         * Search through the database for an "equivilant" movie.
         * When one is found, replace that movie with the new one.
         * Save the file after this.
         */
        public void updateMovie(Movie newMovie) {
            for (int i = 0; i < movieList.Count; i++) {
                if (newMovie.equals(movieList[i])) {
                    movieList[i] = newMovie;
                    Console.WriteLine("update successful");
                }
            }
            saveXML();
        }

        /*
         *  Saves the movie data to the XML file specefied by FILE_NAME.
         */
        private void saveXML() {
            XDocument xdoc = new XDocument(new XElement("movieList"));
            foreach (Movie movie in movieList) {
                XElement root = new XElement("movie");
                root.Add(new XElement("title", movie.getTitle()));
                root.Add(new XElement("year", movie.getYear()));
                root.Add(new XElement("length", movie.getLength()+" mins"));
                root.Add(new XElement("certification", movie.getCertification()));
                root.Add(new XElement("director", movie.getDirector()));
                root.Add(new XElement("rating", movie.getRating()));
                root.Add(new XElement("userrating", movie.getUserRating()));
                root.Add(new XElement("review", movie.getReview()));
                root.Add(new XElement("watchedDate", movie.getDateWatched()));
                foreach (String genre in movie.getGenres()) {
                    root.Add(new XElement("genre", genre));
                }
                foreach (String actor in movie.getActors()) {
                    root.Add(new XElement("actor", actor));
                }
                xdoc.Element("movieList").Add(root);
            }
            xdoc.Save(FILE_NAME);
        }


        /*
         * Loads the contents of FILE_NAME into this MovieData.
         */
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
                    String certification = null;
                    String director = null;
                    String review = null;
                    String dateWatched = null;
                    int rating = 99;
                    int userRating = 99;
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
                                certification = p2.Value;
                                break;
                            case "review":
                                review = p2.Value;
                                break;
                            case "watchedDate":
                                dateWatched = p2.Value;
                                break;
                            case "director":
                                director = p2.Value;
                                break;
                            case "rating":
                                rating = Convert.ToInt32(p2.Value);
                                break;
                            case "userrating":
                                userRating = Convert.ToInt32(p2.Value);
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
                    Movie movie = new Movie(name, year, length,certification, director, rating,userRating, review,dateWatched, genres, actors);
                    movieList.Add(movie);
                }//foreach descendant
                this.movieList = movieList;
            } else {
                //MessageBox.Show("xmlSource.xml not found. No data loaded.");
            }
        }

        /*
         *  Using the given arguments, search through the database for movies that match
         *  the search criteria.
         *  
         *  When those movies are found, divide them among pages set in lists so that
         *  they can be easily displayed.
         */
        public List<List<Movie>> produceQuery(int watchFilterState,int pageTableCapacity, System.Windows.Forms.CheckedListBox genreCheckedList, System.Windows.Forms.CheckedListBox certifCheckedList, String searchQuery, String[] actorQuery, String directorQuery, int yearFrom, int yearTo, int lengthFrom, int lengthTo) {
            List<List<Movie>> pageList = new List<List<Movie>>();
            List<Movie> page = new List<Movie>();

            //Get the selected genres
            List<string> selectedGenreList = new List<string>();
            foreach (Object item in genreCheckedList.CheckedItems) {
                selectedGenreList.Add(item.ToString());
            }
            //Get the selected certifications
            List<string> selectedCertifList = new List<string>();
            foreach (Object item in certifCheckedList.CheckedItems) {
                selectedCertifList.Add(item.ToString());
            }
            //Quick 'n' dirty implementation, itereate through each movie in the database.
            foreach (Movie movie in movieList) {
                if (movie.getYear() >= yearFrom && movie.getYear() <= yearTo
                    && movie.getLength() >= lengthFrom && movie.getLength() <= lengthTo
                    && movie.genreMatch(selectedGenreList)
                    && movie.certifMatch(selectedCertifList)
                    && movie.containsActors(actorQuery)
                    && movie.containsDirector(directorQuery)
                    && movie.meetWatchFilter(watchFilterState)){
                    if (!String.IsNullOrWhiteSpace(searchQuery) && movie.getTitle().Contains(searchQuery)) {
                        page.Add(movie);
                    } else if (String.IsNullOrWhiteSpace(searchQuery)) {
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
        }//produceQuery

        /*
         *  Compatability for unformatted databases (still have min specified in length attribute)
         *  
         *  Takes a string like "84 min" and extracts the 84 from it.
         */
        private int parseLength(string input) {
            int length = -1;
            string[] token = input.Split(null);
            if (token.Length > 0) {
                length = Convert.ToInt32(token[0]);
            }
            return length;
        }
    }
}
