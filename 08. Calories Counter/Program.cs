using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            double calories = 0;

            for (int i = 0; i < num; i++)
            {
                string product = Console.ReadLine().ToLower(); 

                if (product == "cheese")
                {
                    calories += 500;
                }
                else if (product == "tomato sauce")
                {
                    calories += 150;
                }
                else if (product == "salami")
                {
                    calories += 600;
                }
                else if (product == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
