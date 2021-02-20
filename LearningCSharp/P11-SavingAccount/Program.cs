using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_SavingAcmonth
{
    class Program
    {
        static void Main(string[] args)
        {
            double investedMoney = 1000;
            int month = 1;
            double factor = 1+(0.36/100);
            Console.WriteLine("Value invested: " + investedMoney);
            while(month < 12)
            {
                investedMoney *= factor;
                Console.WriteLine("After "+ month + " months, that is the amount: R$" + investedMoney);
                month++;
            }
            Console.ReadLine();
        }
    }
}
