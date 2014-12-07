using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Proj {
    public class Friend {

        public String name;
        public List<String> favoriteGenres;
        public int index;
        public String imageFilePath;

        public Friend(String name) {
            this.name = name;
            favoriteGenres = new List<string>();
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
