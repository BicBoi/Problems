using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int Number;
            int product;
            Console.WriteLine("Enter the number");
            input = Console.ReadLine();
            Number = Convert.ToInt32(input);
            product = Number * Number ;
            Console.WriteLine(product);
            product = Number * Number * Number;
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
