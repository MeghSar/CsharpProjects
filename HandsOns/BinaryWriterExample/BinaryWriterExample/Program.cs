using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"E:\Capgemini\.Net core\Test\BinaryWriterText.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                writer.Write("Current Date and Time is : " + DateTime.Now.ToString());
                writer.Write(true);
            }
            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open, FileAccess.Read)))
            {
                Console.WriteLine(reader.ReadString());
            }
            Console.ReadKey();
        }
    }
}
