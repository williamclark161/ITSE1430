using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            do
            {
                char choice = GetInput();
                switch (choice)
                {
                    case 'a': // Fall Through
                    case 'A': AddProduct(); break;

                    case 'l':
                    case 'L': ListProducts(); break;

                    

                    case 'q':
                    case 'Q': quit = true; break;
                };
            } while (!quit);
        }

        private static void AddProduct()
        {
            Console.Write("Enter product name: ");
            productName = Console.ReadLine().Trim();

            // Ensure not Empty

            Console.Write("Enter price (> 0): ");
            string price = Console.ReadLine().Trim();

            // Check price

            Console.Write("Enter optional description: ");
            productDescription = Console.ReadLine().Trim();

            Console.Write("Is it discontined (Y/N)? ");
            string discontinued = Console.ReadLine().Trim();

            // Check answer
        }

        private static void ListProducts()
        {
            // Name $price (Discontinued)
            // Discription
            //string message = String.Format("{0}\t\t\t${1}\t\t{2}", productName, productPrice,
            //    productDiscontinued ? "[Discontinued]" : "");
            string message = $"{productName}\t\t\t${productPrice}\t\t{(productDiscontinued ? "[Discontinued]" : "")}";

            Console.WriteLine(message);
            Console.WriteLine(productDescription);
            Console.WriteLine();
       }

        static char GetInput()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("".PadLeft(10), "-");
                Console.WriteLine("(A)dd Product");
                Console.WriteLine("(L)ist Products");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine().Trim();

                // Option 1 - String Literal
                //if (input != "")

                // Option 2
                //if (input != String.Empty)

                //Option 3
                if (input != null && input.Length != 0)
                {
                    // String Comparision
                    if (String.Compare(input, "A", true) == 0)
                        return 'A';

                    // Char Comparison
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

                // Error
                Console.WriteLine("Please choose a valid option");
            };
        }

        /*static void Main2(string[] args)
        {
            /* Option 1
            string name = "John" + "Williams" + "Murphy" + "Henry";
            
            // Option 2
                stringBuilder builder = new StringBuilder();
                builder.append("John");
                builder.append("William");
                string name2 = builder.ToString();

            // Option 3
            string name3 = String.Concat("John" + "Williams" + "Murphy" + "Henry");
            
            
            // Option 4
            string format1 = name + " worked " + hours + " hours";

            // Option 5
            string format2 = String.Format("{0} worked for {1} hours", name, hours);

            // Option 6 - Preferred Approach Going Forward
            string format3 = $"{name} worked for {hours} hours";*/

        // Product
        static string productName;
        static decimal productPrice;
        static string productDescription;
        static bool productDiscontinued;



    }
}
