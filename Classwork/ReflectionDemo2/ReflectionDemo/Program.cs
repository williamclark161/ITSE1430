using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeName = "System.DateTime";

            var dt = DateTime.Now;

            Type type = dt.GetType();
            DisplayType(type);
        }

        static void DisplayType (Type type)
        {
            Console.WriteLine($"Name = {type.Name}");
            Console.WriteLine($"FullName = {type.FullName}");
            Console.WriteLine($"Base Type = {type.BaseType}");
            Console.WriteLine($"Name = {type.}");
        }
    }
}
