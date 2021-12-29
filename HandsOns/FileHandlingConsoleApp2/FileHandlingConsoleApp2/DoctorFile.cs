using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingConsoleApp2
{
    class DoctorFile
    {
       public void CreateDoctorFile()
        {
            //Creating file
            FileStream fsObj = new FileStream("E:\\Capgemini\\.Net core\\Test\\DoctorDetails.txt", FileMode.Create, FileAccess.Write);

            //Writing on file
            StreamWriter sw = new StreamWriter(fsObj);

            sw.WriteLine("WELCOME!");

            Console.WriteLine("Please fill the details below...\n");
            Console.Write("Name: Dr.");
            string name = Console.ReadLine();
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Experience: ");
            string expr = Console.ReadLine();
            Console.Write("Address: ");
            string addr = Console.ReadLine();
            Console.Write("Contact Number: ");
            int contact = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("Name : Dr.{0}",name);
            sw.WriteLine("Category : {0}", category);
            sw.WriteLine("Experience : {0}", expr+" years");
            sw.WriteLine("Address : {0}", addr);
            sw.WriteLine("Contact : {0}", contact);

            sw.Close();
            fsObj.Close();
        }
    }
}
