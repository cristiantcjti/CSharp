using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing project - 7!");
            int personAged = 18;
            int yearsOfExp = 2;
            bool experienced = yearsOfExp > 1;
            if (personAged >= 18 && experienced == true )
            {
                Console.Write("This person is an adult, he can take part in the project!");
            }
            else
            {
                Console.WriteLine("This person is a teenager and does not have experience, he can not take part in the project!");
            }
            Console.ReadLine();
        }
    }
}