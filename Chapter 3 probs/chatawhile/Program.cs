using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chatawhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            int[] AreaCode = new int[6]{262, 414, 608, 715, 815, 920};
            double[] rate = new double[6]{0.07, 0.10, 0.05, 0.16, 0.24, 0.14};
            string Area;
            string minutes;

            Console.WriteLine("Enter Your Area Code.");
            Area = Console.ReadLine();
            
            Console.WriteLine("How long was your call in minutes?");
            minutes = Console.ReadLine();

            for (int i = 0; i < AreaCode.Length; i++)
            {
 
                if (Area == AreaCode[i].ToString())
                {
                    price = rate[i] * Convert.ToInt32(minutes);
                    Console.WriteLine(price.ToString("C"));
                    break;
                }
                    

            }
        }
    }
}
