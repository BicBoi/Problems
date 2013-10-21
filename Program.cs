using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your zip code and see if we can deliver to you.");

            int[] ZipCode = new int[10];
            ZipCode[0] = 18040;
            ZipCode[1] = 18042;
            ZipCode[2] = 18045;
            ZipCode[3] = 65345;
            ZipCode[4] = 62435;
            ZipCode[5] = 61322;
            ZipCode[6] = 87654;
            ZipCode[7] = 13554;
            ZipCode[8] = 12345;
            ZipCode[9] = 98765;

            string input = Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                if (input == ZipCode[i].ToString())
                {
                    Console.WriteLine("We can deliver to your zip code.");
                    
                }
                else
                {
                    Console.WriteLine("We can't deliver to your zip code.");
                }
                break;
            }

        }
    }
}
