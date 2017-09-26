using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second  = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string result = null;

            for (char i = first; i <= second; i++)
            {
                for (char a = first; a <= second; a++)
                {
                    for (char l = first; l <= second; l++)
                    {
                        string currentSequence = $"{i}{a}{l}";
                        if (!currentSequence.Contains(third))
                        {
                            Console.Write(currentSequence + " ");
                        }
                        

                    }
                }
            }
        }
    }
}
