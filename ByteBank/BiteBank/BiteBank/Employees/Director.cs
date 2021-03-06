﻿using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Director : AuthenticatableEmployee
    {
        public Director(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Creating Director!");
        }
        public override void IncriseSalary()
        {
            Salary *= 0.15;
        }
        public override double GetBonus()
        {
            return Salary * 0.50;
        }
    }
}
