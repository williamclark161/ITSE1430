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
            string choice = displayMenu();
            
            // Perform function of menu choice
            while (choice != "Q")
            {
                switch (choice)
                {
                    case ("L"):
                        listMovies(movieLibrary);
                        break;

                    case ("l"):
                        listMovies(movieLibrary);
                        break;

                    case ("A"):
                        totalMovies = addMovie(movieLibrary, totalMovies);
                        break;

                    case ("a"):
                        totalMovies = addMovie(movieLibrary, totalMovies);
                        break;

                    case ("R"):
                        totalMovies = removeMovie(movieLibrary, totalMovies);
                        break;

                    case ("r"):
                        totalMovies = removeMovie(movieLibrary, totalMovies);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!  Please enter first letter of the following choices");
                        displayMenu();
                        break;
                }
            }  
        }

        // Function to display menu
        static string displayMenu()
        {
            Console.WriteLine("1. (L)ist Movies");
            Console.WriteLine("2. (A)dd Movie");
            Console.WriteLine("3. (R)emove Movie");
            Console.WriteLine("4. (Q)uit");
            Console.Write("What would you like to do?");
            return Console.ReadLine(); ;
        }
    }
}
