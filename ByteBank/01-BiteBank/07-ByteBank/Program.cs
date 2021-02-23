using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total created accounts: " + CurrentAccount.TotalCreatedAccounts);

            CurrentAccount account = new CurrentAccount(145,62534);

            Console.WriteLine(account.Agency);
            Console.WriteLine(account.Number);

            Console.WriteLine("Total created accounts: " + CurrentAccount.TotalCreatedAccounts);

            Console.ReadLine();
        }
    }
}
