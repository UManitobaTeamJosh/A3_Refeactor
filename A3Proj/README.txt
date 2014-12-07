COMP 3020 Assignment 3
Joshua Chan 7722727
Josh Lemer 7634755

============ Project Description ============
Movie database program to allow users to search a database for movies.
Movies in the database can be tagged with user information, such as whether the user has seen the movie before and when,
user reviews, and user ratings (in addition to the database ratings).

The program also provides Friends features that allows the user to define Friends with a name, identifying image,
favorite genre list, and user-made recommended movie list.

These Friends can be added to a Party that analyzed collectively, allows the program to suggest a
genre that the most people in the group might enjoy.

============ Interface Description ============
The program is divided amongst tabs.

Movie Tab
    The movie tab is where users can seach and access the movie database.
    Movies are displayed to the user through a grid of "MovieBoxes". These MovieBoxes
    have space for an image (not implemented), show the title, length, and rating of the movie.
    If there are a large (more than 50) number of films in a search, the results are divided amongst
    pages of 50 movies.
    
    Clicking on a MovieBox opens a form to see more information on that movie.
    That form is called MovieForm.
    
    On the left is a sidebar where the user specifies the criteria of the search.
    If a control is left blank, then that criteria is not used to filter out any movies.
    The sidebar also contains the shortlist, which users can drag movies onto.
    
    On the top of the movie tab are controls that futher filter out movies, and specifically
    affect how each query is shown (does not actually change the search).
    The user can for example, select how they want to see the movie ratings.
    They can choose to see either the database ratings, their own ratings, or both.
    
    The top bar is also used to navigate through the pages either using the textbox to specify
    a page number (restricted within the pages that actually exist) or using the "previous" and "next" buttons.
    
Movie Form
    This form displays the details of the movie. It shows the title, director, actors, genres, database rating, user rating,
    and user review. Users can also add movies to the shortlist from here through the appropriately labelled button.
    
    It's also here that the user can indicate whether or not they've seen the movie through the radio buttons and calender button.
    The user can also fill a textbox labelled as "Review" to write and save a review to that movie.
    
Friends Tab
    The friends tab is where users can see and manage Friends. It's here that users
    can also add friends to a Party where information on that party is displayed (recommended genre).
    Friends are also displayed in boxes similar to movies, and clicking one also opens a form
    to enable editing and the viewing of more information (The FriendForm).
    
    At the top-right is a button that the user can use to create a new friend.
    
    Friends unlike Movies can be deleted and edited more heavily. Since there are multiple interactions, 
    users can right-click FriendBoxes to see the "Add to party","edit", and "delete" options, which all do as they
    describe.
    
    When a Friend is added to the party, the recommended genre updates by itself.

Friend Form
    The Friend Form allows users to view the details of a Friend, and edit their information.
    The friend's favorite genres can be ticked on and off through the checked list box.
    You can keep track of movies you'd like to recommend to them by typing in the name of the movie
    next to the "Add Movie" button and then clicking the button.
    
    Users can also associate an image for their friend here. Clicking the "Set Image" button
    will open an Open File Dialog allowing the user to browse for an image.
    The chosen image will have its filepath which will be used to load the corresponding image.
    
    Friend images can also be cleared away entirely using the "Clear Image" button.
    
    ============ Known Problems ============
    
    -   An issue with drag-and-drop prevents controls that use it from having normal click interactions.
        - In the MovieTabPanel there's a bit of a workaround put on the MovieBoxes.
        - In the Friends tab, since we wanted the context menu (dragging also seems to prevent right-clicks from registering)
            we decided to have context-menus over drag-and-dropping into the Friend's Party.
            
    -   In the "movies.xml" file provided, there seems to be a formatting error.
            There is a second opening tag for the <movielist> attribute on line 199 which caused XML parsing erros with the .net XML.Linq
            libraries. This issue has been fixed in the movies.xml file that we've left.
            
    -   In the "movies.xml" provided there were duplicate movies among the first 13 movies. The file has been fixed to remove the duplicates.
    
============ Installation Procedure ============

Once the project has been built, the resulting A3Proj.exe only needs to have a properly formatted "movies.xml" file in the
same directory to run properly. Files for saving friends and the shortlist will be generated by the program if not present. These files
will be created in the same directory as A3Proj.exe.

It is recommended that A3Proj.exe be put in it's own directory with a "movies.xml" file to serve as its database.
If there is no "movies.xml" then there will be no database to search from and all queries will turn up empty.

An exmaple of a working enviornment can be seen in the "exampleBuild" folder.