using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CurrentAccount account = new CurrentAccount(456, 147852);
                CurrentAccount account2 = new CurrentAccount(698, 897985);

                account2.Transfer(-10, account);

                account.Deposit(50);
                Console.WriteLine(account.Balance);
                account.Withdraw(500);

            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "number")
                {

                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Occurred an exception of ArgumentException with " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Exception of insufficient balace.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Method();

            Console.ReadLine();

        }

        private static void Method()
        {
            TestDivider(0);
        }

        private static void TestDivider(int divider)
        {
            int result = Divide(10, 0);
            Console.WriteLine("Result of the division of 10 by " + divider + " is " + result);
        }

        private static int Divide(int number, int divider)
        {
            try
            {
                return number / divider;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception when trying to divide " + number + " by " + divider);
                throw;
            }

        }
    }
}