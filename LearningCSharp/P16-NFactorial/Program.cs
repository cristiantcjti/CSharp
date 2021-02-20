using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for(int num = 1; num <= 10; num++)
            {
                n *= num;
                Console.WriteLine("N factorial of " + num + " is :" + n);
            }
            Console.ReadLine();
        }
    }
}
