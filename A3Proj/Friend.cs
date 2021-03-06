﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Proj {
    /*
     * COMP 3020 Assignment 3
     * Joshua Chan 7722727
     * Josh Lemer 7634755
     * 
     * Friend represents a friend.
     */
    public class Friend {

        public String name;
        public List<String> favoriteGenres;
        public int index;
        public String imageFilePath;
        public List<String> recMovies;

        public Friend(String name) {
            this.name = name;
            favoriteGenres = new List<String>();
            recMovies = new List<String>();
        }

        public Friend(String name, List<String> favoriteGenres) {
            this.name = name;
            this.favoriteGenres = favoriteGenres;
        }

        public String toString() {
            return name;
        }

    }
}
