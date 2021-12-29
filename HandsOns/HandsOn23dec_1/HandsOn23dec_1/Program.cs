using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn23dec_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> feeList = new List<Course>();

            feeList.Add(new Course { CourseName = "C#", TotalFees = 2000 });
            feeList.Add(new Course { CourseName = "ASP.NET", TotalFees = 3000 });


            Console.WriteLine("Enter your details below... ");
            Console.Write("Roll No : ");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nSelect course:");
            Console.WriteLine("1.C#\n2.ASP.NET\n");

            int select = Convert.ToInt32(Console.ReadLine());
            string course = "";

            if(select == 1)
            {
                course = "C#";
            }
            else if(select == 2 )
            {
                course = "ASP.NET";
            }
            else
            {
                Console.WriteLine("No such course!");
            }

            StudentDetails studObj = new StudentDetails(roll,name,course);

            Console.Write("Fees Paid : ");
            double paid = Convert.ToInt32(Console.ReadLine());

            studObj.GetList(feeList);
            studObj.Payment(paid);
            studObj.Print();
          
            Console.ReadKey();

        }
    }
}
