using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LoadAccounts();
            }
            catch(Exception)
            {
                Console.WriteLine("Main catch");
            }
             
            Console.WriteLine("Opetation finished. Type Enter to close.");
            Console.ReadLine();

        }

        private static void LoadAccounts()
        {
            using (FileReader reader = new FileReader("files.txt"))
            {
                reader.ReadNextLine();
            }

            /*
            FileReader reader = null;
            try
            {
                reader = new FileReader("files.txt");

                reader.ReadNextLine();
                reader.ReadNextLine();
                reader.ReadNextLine();

            }
            catch(IOException)
            {
                Console.WriteLine("Type exception IOException caught and handled.");
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
               
            }*/


        }

        private static void TestInnerException()
        {
            try
            {
                CurrentAccount account1 = new CurrentAccount(456, 147852);
                CurrentAccount account2 = new CurrentAccount(654, 951753);

                //account1.Transfer(100000, account2);
                account1.Withdraw(10000);
            }
            catch (FinancialOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Information about the innerException: ");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);

            }
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