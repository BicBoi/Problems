using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carprice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in the price of your car, asshat.");
            double Commissions;
            string carPrice = Console.ReadLine();
            double Value = Convert.ToInt32(carPrice);

            if (Value <= 15000)
            {
                Commissions = Value * 0.05;
            }

            else if (Value > 15000 && Value <= 24000)
            {
                Commissions = Value * 0.07;
            }
            else
            {
                Commissions = Value * 0.10;
            }
            Console.WriteLine("Your commission is: $" + Commissions);
        }
    }
}
