using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount gabiAccount = new CurrentAccount();

            gabiAccount.holder  = "Gabi";
            gabiAccount.agency  = 863;
            gabiAccount.number  = 863452;
            gabiAccount.balance = 100;

            Console.WriteLine("Holder: " + gabiAccount.holder);
            Console.WriteLine("Agency: " + gabiAccount.agency);
            Console.WriteLine("Number: " + gabiAccount.number);
            Console.WriteLine("Balance: " + gabiAccount.balance);


            Console.ReadLine();
        }
    }
}
