using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing conditionals");

            int age = 32;
            int peopleAmount = 3;
            bool accompanied = true;

            if (peopleAmount >= 2)
            {
                accompanied = true;
            }
            else
            {
                accompanied = false;
            }

            if (age >= 18 || accompanied)
            {
                Console.WriteLine("You're Welcome!");
            }
            else
            {
                Console.WriteLine("Unfortunately you can't go!");
            }
            Console.ReadLine();
        }
    }
}
