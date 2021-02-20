using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersAndText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing project - 5!");

            char firstLetter = 'a';
            Console.WriteLine("This is a char variable: " + firstLetter);

            firstLetter = (char)65;
            Console.WriteLine("This is a casting operation = variable = (char)65: " + firstLetter);

            firstLetter = (char)(firstLetter + 1);
            Console.WriteLine("This is a casting operation = (char)(firstLetter + 1): " + firstLetter);

            string title = "Learning lenguages " + 2020;
            Console.WriteLine("This is a string concatanated = Learning lenguages  + 2020: " + title);

            string ProgrammingLanguages =
@"- .Net 
- Java 
- Javascript";
            Console.WriteLine("This is a string in list format = @ - .Net - Java - Javascript: ");
            Console.WriteLine(ProgrammingLanguages);
            


            Console.ReadLine();
        }
    }
}
