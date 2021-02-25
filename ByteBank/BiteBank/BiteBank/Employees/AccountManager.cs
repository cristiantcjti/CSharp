using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class AccountManager : AuthenticatableEmployee

    {
        public AccountManager(string cpf) : base(4000,cpf)
        {
            Console.WriteLine("Creating Accountant Manager!");
        }
        public override void IncriseSalary()
        {
            Salary *= 0.05;
        }

        public override double GetBonus()
        {
            return Salary * 0.25; 
        }

    }
}
