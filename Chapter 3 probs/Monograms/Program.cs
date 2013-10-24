using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monograms
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMonogram( "A", "J", "M");
            DisplayMonogram("C", "J", "M");
            Console.ReadKey();

        }

        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);
        }

    }

}
