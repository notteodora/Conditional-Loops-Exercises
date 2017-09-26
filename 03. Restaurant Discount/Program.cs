using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double totalSum = 0;
            double price = 0; 


            if (0 < groupSize && groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                 price = 2500;
            }

            else if (groupSize <= 100 && groupSize > 50)
            {
                Console.WriteLine("We can offer you the Terrace");
                 price = 5000;
            }

            else if (groupSize <= 120 && groupSize > 100)
            {
                Console.WriteLine("We can offer you the Great Hall");
                 price = 7500;
            }

           else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            if (package == "Normal" && groupSize < 120)
            {
                totalSum = (price + 500) * 0.95;
                Console.WriteLine($"The price per person is {totalSum / groupSize:f2}$");

            }

            else if (package == "Gold" && groupSize < 120)
            {
                totalSum = (price + 750) * 0.9;
                Console.WriteLine($"The price per person is {totalSum / groupSize:f2}$");

            }
            else if (package == "Platinum" && groupSize < 120)
            {
                totalSum = (price + 1000) * 0.85;
                Console.WriteLine($"The price per person is {totalSum / groupSize:f2}$");

            }

        }
    }
}
