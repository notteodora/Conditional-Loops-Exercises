using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int combinations = 0;
            int result = 0;

            for (int first = n; first >= 1; first--)
            {
                for (int second = 1; second <= m; second++)
                {
                    if (result >= boundary)
                    {
                        break;
                    }
                    else
                    {
                        result += (first * second) * 3;
                        combinations++;
                    }
                }
            }
            if (result >= boundary)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {result} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations" );
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}
