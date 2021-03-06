﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("It is impossible to divede by 0!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("An error ocurrued!");
            }

            Console.ReadLine();
        
        }


        private static void Method()
        {
            TestDivider(0);
        }
        private static void TestDivider(int divider)
        {
            int result = Divide(10,0);
            Console.WriteLine("Result of the division of 10 by " + divider + " is " + result);
        }
           
        private static int Divide(int number, int divider)
        {
            try
            {
                return number / divider;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exception when trying to divide " + number + " by " + divider);
                throw;
            }
            
        }
    }
}