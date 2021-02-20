using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 12;

            switch (month)
            {
                case 1:
                    Console.Write("The month is January!");
                    break;
                case 2:
                    Console.Write("The month is February!");
                    break;
                case 3:
                    Console.Write("The month is March!");
                    break;
                case 4:
                    Console.Write("The month is April!");
                    break;
                case 5:
                    Console.Write("The month is May!");
                    break;
                case 6:
                    Console.Write("The month is June!");
                    break;
                case 7:
                    Console.Write("The month is July!");
                    break;
                case 8:
                    Console.Write("The month is August!");
                    break;
                case 9:
                    Console.Write("The month is September!");
                    break;
                case 10:
                    Console.Write("The month is October!");
                    break;
                case 11:
                    Console.Write("The month is November!");
                    break;
                case 12:
                    Console.Write("The month is December!");
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
