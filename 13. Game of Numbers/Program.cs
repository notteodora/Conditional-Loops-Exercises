using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int lastFirst = 0;
            int lastSecond = 0;

            bool isFound = false;

            int counter = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int k = firstNum; k <= secondNum; k++)
                {
                    if (i + k == magicNum)
                    {
                        i = lastFirst;
                        k = lastSecond;
                        isFound = true;
                    }
                    counter++;
                }
            }
            if (isFound == true)
            {
                Console.WriteLine($"Number found! {firstNum} + {secondNum} = {magicNum}");

            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
            
        }
    }
}
