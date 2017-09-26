using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y") == true)
            {
                noun = noun.Remove(noun.Length - 1);
                Console.WriteLine($"{noun}ies");
            }
           else if (noun.EndsWith( "o" ) == true) 
            {
                Console.WriteLine($"{noun}es");
            }
            else if ((noun.EndsWith("ch") == true))
            {
                Console.WriteLine($"{noun}es");

            }
            else if ((noun.EndsWith("s") == true))
            {
                Console.WriteLine($"{noun}es");

            }
            else if ((noun.EndsWith("sh") == true))
            {
                Console.WriteLine($"{noun}es");

            }
            else if ((noun.EndsWith("x") == true))
            {
                Console.WriteLine($"{noun}es");

            }
            else if ((noun.EndsWith("z") == true))
            {
                Console.WriteLine($"{noun}es");

            }
            else
            {
                Console.WriteLine($"{noun}s");

            }
        }
    }
}
