using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Director
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salary { get; set; }

        public double GetBonus()
        {
            return Salary;
        }
    }
}
