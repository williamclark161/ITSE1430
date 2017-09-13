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
        static void Main(string[] args)
        {
            // Declaring & Initializing Global Variable(s)
            string[] movieLibrary = new string[4];
            resetLibrary(movieLibrary);

            // Welcoming User
            greetUser();
            
            // Display Menu and Recieve User Choice
            string userChoice = displayMenu();
            performChoice(userChoice,movieLibrary);

            // End Program
            thankUser();
        }

        //Greeting User and Giving Instructions
        static void greetUser()
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
        static void resetLibrary(string [] currentLibrary)
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
        }
        
        // Function to Display Menu
        static string displayMenu()
        {
            Console.WriteLine("CocoaVision Movie Library Menu");
            Console.WriteLine("1. (L)ist Movies");
            Console.WriteLine("2. (A)dd Movie");
            Console.WriteLine("3. (R)emove Movie");
            Console.WriteLine("4. (Q)uit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            return Console.ReadLine();
        }

        // Perform Function of Menu Choice
        static void performChoice(string choice, string [] movies)
        {
            while (choice != "Q")
            {
                while (choice != "q")
                {
                    switch (choice)
                    {
                        case ("L"): listMovies(movies); break;
                        case ("l"): listMovies(movies); break;
                        case ("A"): addMovie(movies); break;
                        case ("a"): addMovie(movies); break;
                        case ("R"): removeMovie(movies); break;
                        case ("r"): removeMovie(movies); break;
                        default: Console.WriteLine("Invalid Choice!!  Please enter first letter of the following choices"); Console.WriteLine(); break;
                    }
                    choice = displayMenu(); 
                }
                break;
            }
        }
        
        // Function to Display the Entire Movie Library
        static void listMovies(string [] library)
        {
            
            Console.WriteLine();
            if (library[0] == "")
            {
                Console.WriteLine("Movie Library is currently empty.");
            }
            else
            {
                Console.WriteLine("Title: " + library[0]);
                Console.WriteLine("Description: " + library[1]);
                Console.WriteLine("Run Length: " + library[2]);
                Console.WriteLine("Status: " + library[3]);
            }
            Console.WriteLine();
        }

        // Function to Add a Movie to the Library
        static void addMovie(string [] library)
        {
            Console.WriteLine();
            
            // Getting Movie Title from User
            Console.Write("Enter a Title (Required & Case Sensitive): ");
            string movie = Console.ReadLine();
            while (movie == "")
            {
                Console.Write("You must enter an actual title: ");
                movie = Console.ReadLine();
            }
            library[0] = movie;

            // Getting Movie Description from User
            Console.Write("Enter a discription (Optional): ");
            library[1] = Console.ReadLine();

            // Getting Movie Time Length from User
            bool validLength = false;
            Console.Write("Enter movie length in minutes (Optional): ");
            do 
            {
                library[2] = Console.ReadLine();
                if (library[2] == "")
                {
                    library[2] = "0";
                    validLength = true;
                }
                else
                {
                    if (Convert.ToInt32(library[2]) < 0)
                    {
                        Console.Write("You must enter a value >= 0: ");
                    }
                    else
                    {
                        validLength = true;
                    }
                }
            } while (!validLength);
            
            // Seeing if Movie is Owned by User
            Console.Write("Do you own this movie (Y/N)? ");
            string answer = Console.ReadLine();
            bool validAnswer = false;
            while (!validAnswer)
            {
                switch(answer)
                {
                    case "y": validAnswer = true; library[3] = "Owned"; break;
                    case "Y": validAnswer = true; library[3] = "Owned"; break;
                    case "yes": validAnswer = true; library[3] = "Owned"; break;
                    case "Yes": validAnswer = true; library[3] = "Owned"; break;
                    case "YES": validAnswer = true; library[3] = "Owned"; break;
                    case "n": validAnswer = true; library[3] = "Not Owned"; break;
                    case "N": validAnswer = true; library[3] = "Not Owned"; break;
                    case "no": validAnswer = true; library[3] = "Not Owned"; break;
                    case "No": validAnswer = true; library[3] = "Not Owned"; break;
                    case "NO": validAnswer = true; library[3] = "Not Owned"; break;
                    default: Console.Write("You must enter Yes or No (Y/N): "); answer = Console.ReadLine(); break;
                }
            }
            Console.WriteLine();
        }

        // Function to Remove a Movie from the Library
        static void removeMovie(string [] library)
        {
            Console.WriteLine();
            if (library[0] == "")
            {
                Console.WriteLine("Movie Library is currently empty.");
            }
            else
            {
                Console.Write("Enter The Name Of The Movie You Want To Remove (Case Sensitive): ");
                string movie = Console.ReadLine();
                if (movie == library[0])
                {
                    bool validAnswer = false;
                    Console.Write("Are you sure you want to remove '" + movie + "' from the library(Y/N)? ");
                    while (!validAnswer)
                    {
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "Y": validAnswer = true; resetLibrary(library); break;
                            case "y": validAnswer = true; resetLibrary(library); break;
                            case "N": validAnswer = true; break;
                            case "n": validAnswer = true; break;
                            default: Console.Write("Please enter Y/N: "); answer = Console.ReadLine(); break;
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
