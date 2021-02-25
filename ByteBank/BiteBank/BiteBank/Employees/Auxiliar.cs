using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Auxiliar : Employee
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Creating Auxiliar!");
        }
        public override void IncriseSalary()
        {
            Salary *= 0.1;
        }
        public override double GetBonus()
        {
            return Salary * 0.2;
        }
    }
}
