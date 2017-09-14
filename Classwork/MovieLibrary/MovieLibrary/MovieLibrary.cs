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

        static void Main(string[] args)
        {
            // Declaring Global Variables

            // Welcoming the user
            WelcomeUser();

            
            bool quit = false;
            do
            {
                // Display menu and recieve user choice
                char userChoice = DisplayMenu();

                // Perform user's choice
                switch (choice)
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

        private static void GoodbyeUser()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using the CocoaVision Movie Library.  Crestworld Studios");
        }

        private static void WelcomeUser()
        {
            Console.WriteLine("Welcome to CocoaVision's Movie Library.  Brought to you by Crestworld Studios");
            Console.WriteLine();

            // Display instructions
            Console.WriteLine("Here you will be able to List, Add or Remove Movies from the library.  Start off by choosing what you would like to.");
            Console.WriteLine("Just decide what you would like to do out of the choices and click the first letter of the choice (Not Case Sensitive).");
            Console.WriteLine();
        }

        // Function to display menu
        static char DisplayMenu()
        {
            Console.WriteLine("1. (L)ist Movies");
            Console.WriteLine("2. (A)dd Movie");
            Console.WriteLine("3. (R)emove Movie");
            Console.WriteLine("4. (Q)uit");
            Console.Write("What would you like to do?");

            string choice = Console.ReadLine().Trim();

            if (choice != null && choice.Length != 0)
            {
                /* String Comparision
                if (String.Compare(choice, "A", true) == 0)
                    return 'A';*/

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
        }

        // Perform function of menu choice
        /*static void PerformChoice(string choice)
        {
            while (choice != "Q")
            {
                switch (choice)
                {
                    case ("L"):
                    case ("l"): ListMovies(); break;

                    case ("A"):
                    case ("a"): AddMovie(); break;

                    case ("R"):
                    case ("r"): RemoveMovie(); break;

                    default:
                        DisplayMenu();
                        break;
                };
                choice = DisplayMenu();
            };*/

        // Function to Add a Movie to the Library
        static void AddMovie()
        {
            Console.WriteLine();
            Console.Write("Enter The Title of Movie: ");
            bool valid = false;
            do
            {
                movieTitle = Console.ReadLine().Trim();
                if (movieTitle != null && movieTitle.Length != 0)
                    valid = true;
                else
                    Console.Write("Invalid Entry!  Please Enter a Movie Title: ");
            } while (!valid);

            Console.Write("Optional - Enter The Description of the Movie: ");
            movieDescription = Console.ReadLine().Trim();

            // Revieving Movie Length
            Console.Write("Oprional - Enter the Length of the Movie (In Minutes): ");
            movieLength = ReadInt();
        }

        private static int ReadInt()
        {
            do
            {
                string length = Console.ReadLine();

                // decimal result;
                if (Int32.TryParse(length, out int result))
                {
                    if (result >= 0)
                        return result;
                    else
                        Console.Write("Enter a number >= 0: "); break;
                }
                else
                    Console.Write("Enter a valid value: ");
            } while (true);

        }

        // Function to Display the Entire Movie Library
        static void ListMovies()
        {
            Console.WriteLine();
            Console.WriteLine("List of movies in the library");
            for (int position = 0; position < movieCount; position++)
            {
                Console.WriteLine(library[position]);
            };
        }

       

        // Function to Remove a Movie from the Library
        static void RemoveMovie()
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
                        if (library[position + 1] != "")
                        {
                            library[position] = library[position + 1];
                        }
                        else
                        {
                            library[position] = "";
                        }
                        movieCount--;
                    };
                    else
                    {
                        Console.WriteLine(movie + " is not in movie library");
                    };
                };
                return movieCount;
            }
            else
            {
                Console.WriteLine("There are no movies in the library to remove");
            };
        }
    }
}