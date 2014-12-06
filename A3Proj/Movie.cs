using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Proj {
    public class Movie {

        private String title;
        private int year;
        private int length;
        private String director;
        private int rating;
        private List<String> genreList;
        private List<String> actorList;

        public Movie(String title, int year, int length, String director,
            int rating, List<String> genreList, List<String> actorList) {
            this.title = title;
            this.year = year;
            this.length = length;
            this.director = director;
            this.rating = rating;
            this.genreList = genreList;
            this.actorList = actorList;
        }

        public bool containsGenre(String genreQuery) {
            bool output = false;
            output = genreList.Contains(genreQuery);
            return output;
        }

        /*
         *  Returns true if ALL the strings in actorQueryList exist in actorList.
         *  If actorList is empty, assume that the user is NOT filtering by actors and
         *  always return true.
         */
        public bool containsActors(String[] actorQueryList) {
            bool output = true;
            if (!(actorQueryList.Length == 1 && String.IsNullOrWhiteSpace(actorQueryList[0]))) {
                foreach (String queryActor in actorQueryList) {
                    bool found = false;
                    foreach (String actor in actorList) {
                        if (actor.Equals(queryActor)) {
                            found = true;
                        }
                    }
                    if (!found) {
                        output = false;
                    }
                }
            }
            return output;
        }

        /*
         *  Returns whether or not a director exists in a movie. If a director is not specefied,
         *  we assume a director is not specefied and return true.
         */
        public bool containsDirector(String queryDirector) {
            bool output = true;
            if (!String.IsNullOrWhiteSpace(queryDirector)) {
                output = director.Equals(queryDirector);
            }
            return output;
        }

        /*
         *  Returns true if there exists at least one genre in the parameter, genreCollection
         *  that exists in this movie's genreList.
         */
        public bool genreMatch(ICollection<string> genreCollection) {
            bool output = false;
            foreach (string genreQuery in genreCollection) {
                foreach (string genre in genreList) {
                    if (genre.Equals(genreQuery)) {
                        return true;
                    }
                }
            }
            return output;
        }

        /*
         *  Changes the rating of the movie. 
         *  A valid movie rating is
         *      >= 0
         *      <= 5
         *  
         *  Returns true if the rating was changed successfully.
         *  Returns false if the rating was unable to be changed.
         */
        public bool changeRating(int newRating) {
            bool output = false;
            if (newRating >= 0 && newRating <= 5) {
                output = true;
            }
            return output;
        }


        //Accessors
        public String getTitle() { return title; }
        public int getYear() { return year; }
        public int getLength() { return length; }
        public String getDirector() { return director; }
        public int getRating() { return rating; }
        public String[] getGenres() { return genreList.ToArray(); }
        public String[] getActors() { return actorList.ToArray(); }

        /*
         *  Produces a string representing the movie. The string is of the format
         *  Title Year Length Director Rating
         *      {Genre1,Genre2...}
         *      {Actor1,Actor2...}
         */
        public string toString() {
            String output = title + " " + year + " " + length + " " + director + " " + rating;
            output += "\n\t{";
            foreach (string genre in genreList) {
                output += genre + ",";
            }
            output += "}\n\t{";
            foreach (string actor in actorList) {
                output += actor + ",";
            }
            output += "}";
            return output;
        }
    }
}
