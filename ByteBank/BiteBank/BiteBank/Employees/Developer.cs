using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Creating Developer");
        }
        public override void IncriseSalary()
        {
            Salary *= 0.15;
        }
        public override double GetBonus()
        {
            return Salary * 0.2;
        }
    }
}
