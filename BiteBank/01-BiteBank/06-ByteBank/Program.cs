using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount();
            Client client = new Client();
            client.Holder = "John";
            client.Cpf = "123.456.789-01";
            client.Profession = "Dev C#";

            account.Holder = client; // encapsulated

            Console.WriteLine(account.Holder.Holder); // encapsulated
            Console.WriteLine(account.Holder.Cpf); // encapsulated
            Console.WriteLine(account.Holder.Profession); // encapsulated

            account.Balance = 10; // encapsulated
            Console.WriteLine("Balance's account: " + account.Balance); // encapsulated



            Console.ReadLine();
        }
    }
}
