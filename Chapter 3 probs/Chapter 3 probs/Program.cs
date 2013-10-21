using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine(" Type P for pine, O for oak, M for mahogany.");
            string input = Console.ReadLine();
            if (input == "P")
            {
                Console.WriteLine("Pine tables cost 100$.");
            }
            
            else if (input == "M")
            {
                Console.WriteLine("Mahogany tables cost 310$");
            }
            else
            {
                Console.WriteLine("Oak tables cost 225$");
            }

        }
    }
}
