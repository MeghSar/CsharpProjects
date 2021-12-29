using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReaderAndWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I am reading \n File Handling at \n Complete C# Tutorial.com";
            //Writing string into StringBuilder
            StringBuilder sb = new StringBuilder();
            using (StringWriter writer = new StringWriter(sb))
            {
                //Store Data on StringBuilder
                writer.WriteLine(text);
                writer.Flush();
                writer.Close();
            }
            //Read Entry
            using (StringReader reader = new StringReader(sb.ToString()))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
