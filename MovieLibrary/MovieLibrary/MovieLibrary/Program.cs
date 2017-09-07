/* Class: ITSE-1430 C# Programming
 * Project: Lab 1 - Movie Library
 * Programmer: William Clark - Crestworld
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary {
    class Program {
        static void Main(string[] args)
        {
            // Declaring Global Variables
            int totalMovies = 0;
            string[] movieLibrary = new string[totalMovies];

            // Welcoming the user
            Console.WriteLine("Welcome to CocoaVision's Movie Library.  Brought to you by Crestworld Studios");
            Console.WriteLine();

            // Display instructions
            Console.WriteLine("Here you will be able to List, Add or Remove Movies from the library.  Start off by choosing what you would like to.");
            Console.WriteLine("Just decide what you would like to do out of the choices and click the first letter of the choice (Not Case Sensitive).");
            Console.WriteLine();

            // Display menu and recieve user choice
            string userChoice = displayMenu();
            performChoice(userChoice,movieLibrary, totalMovies);

        }

        // Function to display menu
        static string displayMenu()
        {
            Console.WriteLine("1. (L)ist Movies");
            Console.WriteLine("2. (A)dd Movie");
            Console.WriteLine("3. (R)emove Movie");
            Console.WriteLine("4. (Q)uit");
            Console.Write("What would you like to do?");
            return Console.ReadLine();
        }

        // Perform function of menu choice
        static void performChoice(string choice, string [] movies, int libraryCount)
        {
            while (choice != "Q")
            {
                switch (choice)
                {
                    case ("L"):
                        listMovies(movies, libraryCount);
                        break;

                    case ("l"):
                        listMovies(movies, libraryCount);
                        break;

                    case ("A"):
                        libraryCount = addMovie(movies, libraryCount);
                        break;

                    case ("a"):
                        libraryCount = addMovie(movies, libraryCount);
                        break;

                    case ("R"):
                        libraryCount = removeMovie(movies, libraryCount);
                        break;

                    case ("r"):
                        libraryCount = removeMovie(movies, libraryCount);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!  Please enter first letter of the following choices");
                        displayMenu();
                        break;
                }
                choice = displayMenu();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the CocoaVision Movie Library.  Crestworld Studios");
        }
        
        // Function to Display the Entire Movie Library
        static void listMovies(string [] library, int movieCount)
        {
            Console.WriteLine();
            Console.WriteLine("List of movies in the library");
            for (int position = 0; position < movieCount; position++)
            {
                Console.WriteLine(library[position]);
            }
        }

        // Function to Add a Movie to the Library
        static int addMovie(string [] library, int movieCount)
        {
            Console.WriteLine();
            Console.Write("Enter The Name Of The Movie You Want To Add: ");
            bool added = false;
            string movie = Console.ReadLine();
            for (int position = 0; !added; position++)
            {
                if (library[position] == "")
                {
                    library[position] = movie;
                    added = true;
                }
            }
            return movieCount++;
        }

        // Function to Remove a Movie from the Library
        static int removeMovie(string [] library, int movieCount)
        {
            Console.WriteLine();
            if (movieCount > 0)
            {
                Console.Write("Enter The Name Of The Movie You Want To Remove: ");
                string movie = Console.ReadLine();
                for (int position = 0; position < movieCount; position++)
                {
                    if (library[position] == movie)
                    {
                        if (library[position+1] != "")
                        {
                            library[position] = library[position+1];
                        }
                        else
                        {
                            library[position] = "";
                        }
                        movieCount--;
                    }
                    else
                    {
                        Console.WriteLine(movie + " is not in movie library");
                    }
                }
                return movieCount;
            }
            else
            {
                Console.WriteLine("There are no movies in the library to remove");
            }
        }
    }
}
