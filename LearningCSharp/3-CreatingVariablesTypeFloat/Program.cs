using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CreatingVariablesTypeFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing project - 3");
            double salary;
            salary = 1200.70;
            Console.WriteLine(salary);

            double age = 32 / 3;
            Console.WriteLine("32 / 3 " + age);

            age = 32.0 / 3;
            Console.WriteLine("32.0 / 3 " + age);
 
            Console.WriteLine("The execution finished. Type any button to close the application...");
            Console.ReadLine();
        }
    }
}
