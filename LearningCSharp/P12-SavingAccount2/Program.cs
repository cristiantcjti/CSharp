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
            double factor = 1 + (0.36 / 100);

            Console.WriteLine("Value invested: " + investedMoney);
            for ( int month = 1; month < 12;month++)
            {
                investedMoney *= factor;
                Console.WriteLine("After " + month + " months, that is the amount: R$" + investedMoney);
            }
            Console.ReadLine();
        }
    }
}