using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Host {
    class Program {
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
            productPrice = ReadDecimal();

            // Check price

            Console.Write("Enter optional description: ");
            productDescription = Console.ReadLine().Trim();

            Console.Write("Is it discontined (Y/N)? ");
            productDiscontinued = ReadYesNo();

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
                Console.WriteLine("(Q)uit");

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

        /// <summary>Reads a decimal from Console.</summary>
        ///
        static bool ReadYesNo()
        {
            do
            {
                string input = Console.ReadLine();

                bool result;
                //if (Boolean.TryParse(input, out result))
                //    return result;

                if (!String.IsNullOrEmpty(input))
                {
                    switch (Char.ToUpper(input[0]))
                    {
                        case 'Y': return true;
                        case 'N': return false;
                    };
                };

                Console.Write("Enter either Y or N: ");
            } while (true);
        }

        /// <summary> Reads a string from Console </summary>
        /// <param name="errorMessage"></param>
        /// <param name="allowEmpty"></param>
        /// <returns></returns>
        static string ReadString(string errorMessage, bool allowEmpty)
        {
            //if (errorMessage == null)
            //    errorMessage = "Enter a valid string";
            //else
            //  errorMessage = erroeMessage.Trim();
            // null coalesce
            errorMessage = errorMessage ?? "Enter a valid string";

            // null conditional
            errorMessage = errorMessage?.Trim();

            do
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input) && allowEmpty)
                    return "";
                else if (!String.IsNullOrEmpty(input))
                    return input;
                        
                Console.WriteLine(errorMessage);
            } while (true);
        }

        
        static decimal ReadDecimal()
        {
            do
            {
                string input = Console.ReadLine();

                // decimal result;
                if (Decimal.TryParse(input, out decimal result))
                    return result;

                Console.WriteLine("Enter a valid decimal: ");
            } while (true);
        }

        // Product
        static string productName;
        static decimal productPrice;
        static string productDescription;
        static bool productDiscontinued;



    }
}
