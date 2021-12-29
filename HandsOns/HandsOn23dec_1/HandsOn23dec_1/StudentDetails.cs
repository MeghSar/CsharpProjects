using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn23dec_1
{
    class StudentDetails
    {
        private int stud_roll;
        private string stud_name;
        private string stud_course;
        private double fees_Paid;
        private double course1_amt;
        private double course2_amt;
        private double course1_amt_actual;
        private double course2_amt_actual;
        private double amt_actual;
        private string course1;
        private string course2;
        static double tax = 0.123D;

        //  Course cr = new Course();
        public void GetList(List<Course> list)
        {
            course1_amt_actual = list[0].TotalFees;
            course2_amt_actual = list[1].TotalFees;
            course1_amt = list[0].TotalFees+ list[0].TotalFees * tax;
            course2_amt = list[1].TotalFees + list[1].TotalFees * tax;
            course1 = list[0].CourseName;
            course2 = list[1].CourseName;
        }
        public StudentDetails(int rollno,string name,string course)
        {
            stud_roll = rollno;
            stud_name = name;
            stud_course = course;

        }
        public void Payment(double amount)
        {
            fees_Paid = amount;
            if(stud_course == course1)
            {
                amt_actual = course1_amt_actual;
                TotalFee = course1_amt;
                DueAmount = (TotalFee - fees_Paid);
                
            }
            else 
            {
                amt_actual = course2_amt_actual;
                TotalFee = course2_amt;
                DueAmount = (TotalFee - fees_Paid);
               
            }


        }
        public void Print()
        {
            Console.WriteLine("\nYour Name = {0}", stud_name);
            Console.WriteLine("Your Course = {0}", stud_course);
            Console.WriteLine("\nTotal Course Fees without tax = {0}", amt_actual);
            Console.WriteLine("Total Course Fees with tax = {0}", TotalFee);
            Console.WriteLine("Fees Due = {0}", DueAmount);

        }
        public double DueAmount { get; set; }
        public double TotalFee { get; set; }
       
    }
}
