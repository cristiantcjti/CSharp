using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_IR
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 3751.01;
            double aliquota1 = 7.5;
            double aliquota2 = 15;
            double aliquota3 = 22.5;
            int vlDeduction1 = 142;
            int vlDeduction2 = 350;
            int vlDeduction3 = 636;
            char perc = '%';
            string real = "R$";

            Console.WriteLine("That is the salary: " + salary);
            if (salary >= 1900.0 && salary <= 2800.0)
            {
                Console.WriteLine("The IR is: " + aliquota1 + perc);
                Console.WriteLine("The value to be deductedis: " + real + vlDeduction1);
            }
            else if (salary >= 2800.01 && salary <= 3751.0)
            {
                Console.WriteLine("The IR is: " + aliquota2 + perc);
                Console.WriteLine("The value to be deductedis: " + real + vlDeduction2);
            }
            else if (salary >= 3751.01)
            {
                Console.WriteLine("The IR is: " + aliquota3 + perc);
                Console.WriteLine("The value to be deductedis: " + real + vlDeduction3);
            }
            Console.ReadLine();
        }
    }
}
