using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1 = 150;
            double value2 = 100;
            double value3 = 500;

            CurrentAccount brunoAccount = new CurrentAccount();
            CurrentAccount gabiAccount = new CurrentAccount();

            brunoAccount.holder = "Bruno";
            gabiAccount.holder = "Gabi";

            Console.WriteLine("This is Bruno's balance account: " + brunoAccount.balance);
            Console.WriteLine("This is Gabi's balance account: " + gabiAccount.balance);
            Console.WriteLine();

            //Withdraw
            Console.WriteLine("Withdraw from Bruno's account: " + value1);
            bool resultWithdraw = brunoAccount.Withdraw(value1);
            Console.WriteLine("Withdraw succesful? " + resultWithdraw);
            Console.WriteLine("Bruno's account balance: " + brunoAccount.balance);
            Console.WriteLine();

            //Deposit
            Console.WriteLine("Deposit into Bruno's account: R$" + value3);
            brunoAccount.Deposit(value3);
            Console.WriteLine("Bruno's balance account: " + brunoAccount.balance);
            Console.WriteLine();

            Console.WriteLine("Tranfer from Bruno's account to Gabi's account: " + value2);
            bool resultTransfer = brunoAccount.Transfer(value2, gabiAccount);
            Console.WriteLine("Transfer succesful? " + resultTransfer);
            Console.WriteLine("Bruno's account balance: " + brunoAccount.balance);
            Console.WriteLine("Gabi's account balance: " + gabiAccount.balance);




            Console.ReadLine();


        }
    }
}
