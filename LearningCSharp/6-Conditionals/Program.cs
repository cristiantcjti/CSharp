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
            Console.WriteLine("Executing project - 6!");
            int personAged = 18;
            int yearsOfExp = 2;
            Console.WriteLine("Person's age: " + personAged);
            Console.WriteLine("Years of experience: " + yearsOfExp);
            if (personAged >= 18)
            {
                Console.Write("This person is an adult, he can take part in the project!");
            }
            else
            {
                if (yearsOfExp > 1)
                {
                    Console.WriteLine("Althoug he's young, he has experience thus he can take part in the project!");
                }
                else
                {
                    Console.WriteLine("This person is a teenager, he can not take part in the project!");
                }
            }
            Console.ReadLine();
        }
    }
}
