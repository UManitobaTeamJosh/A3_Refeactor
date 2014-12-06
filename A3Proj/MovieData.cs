using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace A3Proj {
    /*
     *  MovieData represents a body of movies. It's used to load, save, and access the
     *  movies stored in the XML database.
     */
    public class MovieData {

        private static readonly String FILE_NAME = "movies.xml";
        private List<Movie> movieList;
        private List<List<Movie>> moviePageList;

        public MovieData() {
            movieList = new List<Movie>();
            loadXML();
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
                    Movie movie = new Movie(name, year, length, director, rating, genres, actors);
                    movieList.Add(movie);
                }//foreach descendant
                //Done loading movies. Do something with movielist now.
                /*
                foreach (Movie movie in movieList) {
                    Console.WriteLine(movie.toString());
                }
                */
                this.movieList = movieList;
            } else {
                //MessageBox.Show("xmlSource.xml not found. No data loaded.");
            }
            //Do something with data, like populate a table
        }

        //Produces a list of pages. 
        public List<List<Movie>> produceQuery(int pageTableCapacity, System.Windows.Forms.CheckedListBox genreCheckedList,  String searchQuery,String[] actorQuery ,String directorQuery, int yearFrom, int yearTo, int lengthFrom, int lengthTo) {
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
                    && movie.genreMatch(selectedGenreList)
                    && movie.containsActors(actorQuery)
                    && movie.containsDirector(directorQuery)) {
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
        }

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
