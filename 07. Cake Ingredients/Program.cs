using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int times = 0;


            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                times++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {times} ingredients.");
        }
    }
}

            