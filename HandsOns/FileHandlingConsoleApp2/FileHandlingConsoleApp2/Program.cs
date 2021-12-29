using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            DoctorFile docObj = new DoctorFile();
            docObj.CreateDoctorFile();
            Console.ReadKey();
        }
    }
}
