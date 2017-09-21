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
    class Program 
    {
        // Declaring & Initializing Global Variable(s)
        static string movieTitle = "";
        static string movieDescription = "";
        static int movieLength = 0;
        static bool ownMovie = "";
        
        static void Main(string[] args)
        {
            // Welcoming User
            GreetUser();
            
            // Display Menu and Recieve User Choice
            char userChoice = DisplayMenu();
            PerformChoice(userChoice,movieLibrary);

            // End Program
            ThankUser();
        }

        //Greeting User and Giving Instructions
        static void GreetUser()
        {
            // Display Welcome
            Console.WriteLine("Welcome to CocoaVision's Movie Library.  Brought to you by Crestworld Studios");
            Console.WriteLine();

            // Display Instructions
            Console.WriteLine("Here you will be able to List, Add or Remove Movies from the library.  Start off by choosing what you would like to.");
            Console.WriteLine("Just decide what you would like to do out of the choices and click the first letter of the choice (Not Case Sensitive).");
            Console.WriteLine();
        }
        // Initializing Movie Library
        /*static void ResetLibrary(string [] currentLibrary)
        {
            for (int position = 0; position < 4; position++)
            {
                if (position == 2)
                {
                    currentLibrary[2] = "0";
                }
                else
                {
                    currentLibrary[position] = "";
                }
            }
        }*/
        
        // Function to Display Menu
        static char displayMenu()
        {
            while (true)
            {
                Console.WriteLine("CocoaVision Movie Library Menu");
                Console.WriteLine("1. (L)ist Movies");
                Console.WriteLine("2. (A)dd Movie");
                Console.WriteLine("3. (R)emove Movie");
                Console.WriteLine("4. (Q)uit");
                Console.WriteLine();
                Console.Write("What would you like to do? ");
            
                string choice = Console.ReadLine();
                if (input != null && input.Length != 0)
                {
                    char letter = Char.ToUpper(input[0]);
                        if (letter == 'A')
                        {
                            return 'A';
                        }
                        else if (letter == 'L')
                        {
                            return 'L';
                        }
                        else if (letter == 'Q')
                        {
                            return 'Q';
                        }
                };
                Console.WriteLine("Invalid Choice!!  Please enter first letter of the following choices"); 
                Console.WriteLine();
            };
        }

        // Perform Function of Menu Choice
        static void PerformChoice(string choice, string [] movies)
        {
            bool quit = false;
            do
            {
                switch (choice)
                {
                    case ("L"):
                    case ("l"): ListMovies(movies); break;
                    case ("A"):
                    case ("a"): AddMovie(movies); break;
                    case ("R"):
                    case ("r"): RemoveMovie(movies); break;
                    case ("Q"):
                    case ("q"): quit = true; break;
                };
            } while (!quit);
        }
        
        // Function to Display the Entire Movie Library
        static void ListMovies(string [] library)
        {
            
            Console.WriteLine();
            if (library[0] == "")
            {
                Console.WriteLine("Movie Library is currently empty.");
            }
            else
            {
                Console.WriteLine("Title: " + movieTitle);
                Console.WriteLine("Description: " + movieDescription);
                Console.WriteLine("Run Length: " + movieLength);
                if (ownMovie)
                    Console.WriteLine("Status: Owned");
                else
                    Console.WriteLine("Status: Not Owned");
            }
            Console.WriteLine();
        }

        // Function to Add a Movie to the Library
        static void AddMovie(string [] library)
        {
            Console.WriteLine();
            
            // Getting Movie Title from User
            Console.Write("Enter a Title (Required & Case Sensitive): ");
            movieTitle = Console.ReadLine();
            while (movieTitle == "")
            {
                Console.Write("You must enter an actual title: ");
                movieTitle = Console.ReadLine();
            }
            
            // Getting Movie Description from User
            Console.Write("Enter a discription (Optional): ");
            movieDescription = Console.ReadLine();

            // Getting Movie Time Length from User
            bool validLength = false;
            string length = "";
            Console.Write("Enter movie length in minutes (Optional): ");
            do 
            {
                length = Console.ReadLine();
                if (length == "")
                {
                    length = "0";
                    validLength = true;
                }
                else
                {
                    if (Convert.ToInt32(length) < 0)
                    {
                        Console.Write("You must enter a value >= 0: ");
                    }
                    else
                    {
                        validLength = true;
                    }
                }
            } while (!validLength);
            movieLength = Convert.ToInt32(length);
            
            // Seeing if Movie is Owned by User
            Console.Write("Do you own this movie (Y/N)? ");
            string answer = Console.ReadLine();
            bool validAnswer = false;
            while (!validAnswer)
            {
                switch(answer)
                {
                    case "y":
                    case "Y":
                    case "yes":
                    case "Yes":
                    case "YES": validAnswer = true; ownMovie = true; break;
                    case "n":
                    case "N":
                    case "no":
                    case "No":
                    case "NO": validAnswer = true; ownMovie = false; break;
                    default: Console.Write("You must enter Yes or No (Y/N): "); answer = Console.ReadLine(); break;
                }
            }
            Console.WriteLine();
        }

        static string GetTitle()
        {
            Console.Write("Enter a Title (Required & Case Sensitive): ");
            string movie = Console.ReadLine();
            while (movie == "")
            {
                Console.Write("You must enter an actual title: ");
                movie = Console.ReadLine();
            }
            return movie;
        }
        // Function to Remove a Movie from the Library
        static void RemoveMovie(string [] library)
        {
            Console.WriteLine();
            if (movieTitle == "")
            {
                Console.WriteLine("Movie Library is currently empty.");
            }
            else
            {
                Console.Write("Enter The Name Of The Movie You Want To Remove (Case Sensitive): ");
                string movie = Console.ReadLine();
                if (movie == movieTitle)
                {
                    bool validAnswer = false;
                    Console.Write("Are you sure you want to remove '" + movieTitle + "' from the library(Y/N)? ");
                    while (!validAnswer)
                    {
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "Y": 
                            case "y": 
                                validAnswer = true; 
                                movieTitle = ""; 
                                movieDescription = "";
                                movieLength = 0;
                                ownMovie = false;
                                break;

                            case "N":
                            case "n":
                                validAnswer = true; 
                                break;

                            default: 
                                Console.Write("Please enter Y/N: "); 
                                answer = Console.ReadLine(); 
                                break;
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("The movie '" + movie + "' is not in library");
                }
            }
            Console.WriteLine();
        }

        // Thanking User For Participation - Goodbye
        static void thankUser()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using the CocoaVision Movie Library.  Crestworld Studios");
            Console.WriteLine();
            Console.WriteLine("Hit any key to close...");
            Console.ReadKey();
        }
    }
}
