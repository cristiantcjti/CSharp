using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConvertingNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing project - 4");

            // double = 64 bits
            double salary = 1200.50;
            Console.WriteLine("This is the salary variable: " + salary);
            
            // int = 32 bits
            int salaryAsInt = (int)salary; // casting from double to int.
            Console.WriteLine("This is the double salary variable converted to int: " + salaryAsInt);
            
            // long = int of 64 bits
            long universeAge = 130000000000000;
            Console.WriteLine("This is a long int variable: " + universeAge);

            // short = int of 16 bit
            short productQuantity = 15000;
            Console.WriteLine("This is a short int variable: " + productQuantity);
            
            // float = just a small decimal precision
            float height = 1.83f;
            Console.WriteLine("This is a float variable: " + height);

            Console.WriteLine("The application finished. Type any button to close...");
            Console.ReadLine();

            /* Casting
             * To/From	byte	short	char	int	    long	float	double
             *  byte	----	Impl.	(char)	Impl.	Impl.	Impl.	Impl.
                short	(byte)	----	(char)	Impl.	Impl.	Impl.	Impl.
                char	(byte)	(short)	----	Impl.	Impl.	Impl.	Impl.
                int	    (byte)	(short)	(char)	----	Impl.	Impl.	Impl.
                long	(byte)	(short)	(char)	(int)	----	Impl.	Impl.
                float	(byte)	(short)	(char)	(int)	(long)	----	Impl.
                double	(byte)	(short)	(char)	(int)	(long)	(float)	----
             */
        }
    }
}
