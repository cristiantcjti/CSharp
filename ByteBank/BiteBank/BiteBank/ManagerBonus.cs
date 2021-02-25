using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ManagerBonus
    {
        private double _totalBonus;
        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }
        public double TotalBonus()
        {
            return _totalBonus;
        }

    }
}
