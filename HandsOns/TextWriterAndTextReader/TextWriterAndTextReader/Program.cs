using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextWriterAndTextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"E:\Capgemini\.Net core\Test\TextWriterReaderExample.txt";
            //Writting File
            using (TextWriter writer = File.CreateText(file))
            {
                writer.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("Successfully Added Current Date and Time");
            }
            //Reading File
            using (TextReader reader = File.OpenText(file))
            {
                Console.Write("Reading Current Time : ");
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}