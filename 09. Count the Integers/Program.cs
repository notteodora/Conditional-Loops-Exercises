using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;

            try
            {
                int num = int.Parse(Console.ReadLine());
                while (0 < num || num >= 0 )
                {
                    times++;
                    num = int.Parse(Console.ReadLine());
                }

            }
            catch (Exception)
            {

                Console.WriteLine($"{times}");
            }
        }
    }
}
