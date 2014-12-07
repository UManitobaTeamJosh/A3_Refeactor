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
        private int userRating;
        private String review;
        private String dateWatched;
        private List<String> genreList;
        private List<String> actorList;

        public Movie(String title, int year, int length, String director,
            int rating,int userRating, String review,String dateWatched, List<String> genreList, List<String> actorList) {
            this.title = title;
            this.year = year;
            this.length = length;
            this.director = director;
            this.rating = rating;
            this.userRating = userRating;
            this.review = review;
            this.dateWatched = dateWatched;
            this.genreList = genreList;
            this.actorList = actorList;
        }

        public bool containsGenre(String genreQuery) {
            bool output = false;
            output = genreList.Contains(genreQuery);
            return output;
        }

        /*
         *  Two movies are considered identical if they have the same title, length, and year.
         */
        public bool equals(Movie other) {
            return (title.Equals(other.getTitle()) && year == other.getYear() && length == other.getLength());
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
            if (genreCollection.Count == 0) {
                return true;
            }
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
         *      <= 10
         *  
         *  Returns true if the rating was changed successfully.
         *  Returns false if the rating was unable to be changed.
         */
        public bool changeRating(int newRating) {
            bool output = false;
            if (newRating >= 0 && newRating <= 10) {
                output = true;
                rating = newRating;
            }
            return output;
        }

        /*
         *  Changes the rating of the movie. 
         *  A valid movie rating is
         *      >= 0
         *      <= 10
         *  
         *  Returns true if the rating was changed successfully.
         *  Returns false if the rating was unable to be changed.
         */
        public bool changeUserRating(int newRating) {
            bool output = false;
            if (newRating >= 0 && newRating <= 10) {
                output = true;
                userRating = newRating;
            }
            return output;
        }

        public void setReview(String review) {
            this.review = review;
        }

        public void setDateWatched(String date) {
            this.dateWatched = date;
        }


        //Accessors
        public String getTitle() { return title; }
        public int getYear() { return year; }
        public int getLength() { return length; }
        public String getDirector() { return director; }
        public int getRating() { return rating; }
        public int getUserRating() { return userRating; }
        public String getReview() { return review; }
        public String getDateWatched() { return dateWatched; }
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
