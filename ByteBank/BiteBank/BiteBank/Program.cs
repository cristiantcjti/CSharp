using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Employees;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerBonus managerBonus = new ManagerBonus();

            Employee cris = new Employee();
            cris.Name = "Cristian Silva";
            cris.CPF = "123.456.789-01";
            cris.Salary = 2000;

            managerBonus.Register(cris);

            
            Director paul = new Director();
            paul.Name = "Paul Wilians";
            paul.CPF = "987.654.321-10";
            paul.Salary = 5000;

            managerBonus.Register(paul);

            Console.WriteLine(cris.Name);
            Console.WriteLine(cris.CPF);
            Console.WriteLine(cris.Salary);
            Console.WriteLine("This is " + cris.Name + " bonus: " + cris.GetBonus());
            Console.WriteLine();
            Console.WriteLine(paul.Name);
            Console.WriteLine(paul.CPF);
            Console.WriteLine(paul.Salary);
            Console.WriteLine("This is " + paul.Name + " bonus: " + paul.GetBonus());
            Console.WriteLine();
            Console.WriteLine("This is the total bonus: "+ managerBonus.TotalBonus());

            Console.ReadLine();

        }
    }
}
