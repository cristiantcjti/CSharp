using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_Multiples3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers multiples of 3 between 1 and 100: ");
            for (int number = 1; number <= 100; number++)
            {
                if (number % 3 == 0)
                {
                    Console.Write(number+", ");
                }
            }
            Console.ReadLine();
               
        }
    }
}
