using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _11_ByteBank
{
    public class FileReader : IDisposable
    {
        public string File { get; }

        public FileReader(string file)
        {
            File = file;

            //throw new FileNotFoundException();

            Console.WriteLine("Opening file: " + file);
        }
        
        public string ReadNextLine()
        {
            Console.WriteLine("Reading next line...");

            //throw new IOException();

            return "File line";
        }
       
        public void Dispose()
        {
            Console.WriteLine("Closing file.");
        }
    }
}
