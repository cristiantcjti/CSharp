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
            //CurrentAccount account = new CurrentAccount(7480, 954781);
            try
            {
                Method();
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
            Console.ReadLine();
        }
        static void Method()
        {
            try
            {
                TestDivider(0);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }

        }

        static void TestDivider(int divider)
        {
            Divide(10, divider);
        }

        static int Divide(int number, int divider)
        {
            CurrentAccount account = null;
            Console.WriteLine(account.Balance);
            return number / divider;
        }
    }
}