/* Class: ITSE-1430 C# Programming
 * Project: Lab 1 - Movie Library
 * Programmer: William Clark - Crestworld
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class MovieLibrary
    {
        // Movie Values
        static string movieTitle;
        static string movieDescription;
        static int movieLength;
        static bool movieOwned;

        /// <summary>
        /// This program will provided choices for a user to add, list or remove movies from a movie library.  When the user is done, they can chose to quit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Welcoming the user
            WelcomeUser();

            // Gather and Process User Choices
            bool quit = false;
            do
            {
                // Display menu and recieve user choice
                char userChoice = DisplayMenu();

                // Perform user's choice
                switch (userChoice)
                {
                    case 'a': // Fall Through
                    case 'A': AddMovie(); break;

                    case 'l':
                    case 'L': ListMovies(); break;

                    case 'r':
                    case 'R': RemoveMovie(); break;

                    case 'q':
                    case 'Q': quit = true; break;
                };
            } while (!quit);

            GoodbyeUser();
        }

        /// <summary>
        /// This function simply displays a welcome to the user with a brief discription of what this program does.  No values will be returned.
        /// </summary>
        private static void WelcomeUser()
        {
            // Display Welcome
            Console.WriteLine("Welcome to CocoaVision's Movie Library.  Brought to you by Crestworld Studios");
            Console.WriteLine();

            // Display Discription
            Console.WriteLine("Here you will be able to List, Add or Remove Movies from the library.  Start off by choosing what you would like to.");
            Console.WriteLine();
        }

        /// <summary>
        /// This function will display a menu showing the user they choices they can make and the program will perform them.
        /// </summary>
        /// <returns>A character for listing, adding, removing movie(s) or quitting the program.</returns>
        private static char DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. (L)ist Movies");
                Console.WriteLine("2. (A)dd Movie");
                Console.WriteLine("3. (R)emove Movie");
                Console.WriteLine("4. (Q)uit");
                Console.Write("What would you like to do?");

                string choice = Console.ReadLine().Trim();

                Console.WriteLine();
                if (choice != null && choice.Length != 0)
                {
                    // Char Comparison
                    char letter = Char.ToUpper(choice[0]);
                    if (letter == 'A')
                    {
                        return 'A';
                    }
                    else if (letter == 'L')
                    {
                        return 'L';
                    }
                    else if (letter == 'R')
                    {
                        return 'R';
                    }
                    else if (letter == 'Q')
                    {
                        return 'Q';
                    }
                };

                // Error Message
                Console.Write("Invalid Choice!!  Please choose a valid choice: ");
            };

        }

        /// <summary>
        /// This function will perform the user choice of adding a movie by collecting the movie information from the user including he title, discription, 
        /// run time length and if the movie is owned by the user.  No values will be returned.
        /// </summary>
        private static void AddMovie()
        {
            Console.WriteLine();
            Console.WriteLine("Adding A Movie (* = Required Entry)");
            Console.WriteLine();
            Console.Write("*Enter The Title of Movie: ");
            bool valid = false;
            do
            {
                movieTitle = Console.ReadLine().Trim();
                if (movieTitle != null && movieTitle.Length != 0)
                    valid = true;
                else
                    Console.Write("Invalid Entry!  Please Enter a Movie Title: ");
            } while (!valid);

            Console.Write("Enter The Description of the Movie: ");
            movieDescription = Console.ReadLine().Trim();

            // Revieving Movie Length
            Console.Write("Enter the Length of the Movie (In Minutes): ");
            movieLength = ReadInt();

            // Retrieving Movie Ownership
            Console.Write("*Do you currently own this movie? ");
            movieOwned = CheckingOwnership();
        }

        /// <summary>
        /// This function will recieve the answer from the user on whether they own the movie or not.
        /// </summary>
        /// <returns>boolean value indicating the ownership of the movie.</returns>
        private static bool CheckingOwnership()
        {
            string owned;

            do
            {
                owned = Console.ReadLine();

                //bool result;
                
                if (!String.IsNullOrEmpty(owned))
                {
                    switch (Char.ToUpper(owned[0]))
                    {
                        case 'Y': return true;
                        case 'N': return false;
                    };
                };

                Console.Write("Invalid Choice!! Please Answer Yes or No: ");
            } while (true);

        }

        /// <summary>
        /// This function will recieve a integer value from the user on the run time length of the movie.
        /// </summary>
        /// <returns>an integer as the value of the movie length.</returns>
        private static int ReadInt()
        {
            do
            {
                string length = Console.ReadLine();

                // decimal result;
                if (Int32.TryParse(length, out int result) && result >= 0)
                    return result;
                
                Console.Write("Enter a valid value (>= 0): ");
            } while (true);

        }

        /// <summary>
        /// This function will display a list of the movie(s) in the library.  No values will be returned.
        /// </summary>
        private static void ListMovies()
        {
            if (movieTitle != null && movieTitle.Length != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Movie Title: " + movieTitle);
                Console.WriteLine("Movie Description: " + movieDescription);
                Console.WriteLine("Movie Lendth: " + movieLength);
                Console.Write("Currently Owned: ");
                if (movieOwned)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else
                Console.WriteLine("Movie Library is Empty");
        }

        /// <summary>
        /// This function will remove a movie us the user's chosing from the library.   No values will be returned.
        /// </summary>
        private static void RemoveMovie()
        {
            if (movieTitle != null && movieTitle.Length != 0)
            {
                bool found = false;
                do
                {
                    
                    Console.Write("Enter The Title Of The Movie You Want To Remove: ");
                    string title = Console.ReadLine();
                    if (title == movieTitle)
                    {
                        found = true;
                        movieTitle = "";
                        movieDescription = "";
                        movieLength = 0;
                        movieOwned = false;
                    }
                    else
                    {
                        Console.WriteLine(title + " is not in movie library");
                        Console.WriteLine();
                    }
                } while (!found);
            }
            else
                Console.WriteLine("There are no movies in the library to remove");
        }

        /// <summary>
        /// This function will issue a thank you and goodbye to the user.  Ending the program.  No values will be returned.
        /// </summary>
        private static void GoodbyeUser()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using the CocoaVision Movie Library.  Crestworld Studios");
            Console.WriteLine();
            Console.Write("Please press any key....");
            Console.ReadKey();
        }
    }
}