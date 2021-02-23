using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client gabriela = new Client();
            CurrentAccount account = new CurrentAccount();

            gabriela.holder = "Gabriela Silva";
            gabriela.cpf = "123.456.789-01";
            gabriela.profession = "Dev C#";

            account.holder = gabriela;

            Console.WriteLine(gabriela.holder);
            Console.WriteLine(account.holder.holder);

            account.holder.holder = "Gabriela Santana";

            Console.WriteLine(gabriela.holder);
            Console.WriteLine(account.holder.holder);

            Console.ReadLine();
        }
    }
}
