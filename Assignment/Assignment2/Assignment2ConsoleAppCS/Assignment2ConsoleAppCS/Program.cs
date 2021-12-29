using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2ConsoleAppCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Roll : ");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            string name =Console.ReadLine();
            Console.Write("Enter Course Joined(C# / ASP.NET) : ");
            string course =Console.ReadLine();
            Console.Write("Enter Fees Paid So Far : Rs.");
            double paid = Convert.ToDouble(Console.ReadLine());


            StudentDetails studObj = new StudentDetails(roll, name, course);
            studObj.Payment(paid);
            studObj.Print();

            Console.ReadKey();
        }
    }
}
