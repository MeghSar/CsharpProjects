using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2ConsoleAppCS
{
    
    class StudentDetails
    {
        private int roll;
        private string name;
        private string course;
        private double feesPaid;
        double dueAmount;
        double totalAmount;

        public StudentDetails(int student_roll,string student_name,string course_name)
        {
            roll = student_roll;
            name = student_name;
            course = course_name;
            if (course=="C#")
            {
                totalAmount = 2000;
            }
            else
            {
                totalAmount = 3000;
            }
       
        }

        public void Payment(double amount)
        {
            feesPaid = amount;
            dueAmount = totalAmount - feesPaid;
        }
        public void Print()
        {
            Console.WriteLine("\n\nPrinting Details...");
            Console.WriteLine("__________________________________");
            Console.WriteLine("Roll : " + roll);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Course Joined : " + course);

            Console.WriteLine("Total Ammount : Rs." +totalAmount);
            Console.WriteLine("Amount Paid : Rs." + feesPaid);
            Console.WriteLine("Due Amount : Rs." + dueAmount);
            Console.WriteLine("__________________________________");

            Console.WriteLine("Press any key to exit.");
        }
        

    }
}
