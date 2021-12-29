using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2CSharp
{
    
    class Student:Person
    {
        
        private int[] testScores ;
        public Student(string firstName, string lastName, int id,int[] Scores):
            base(firstName, lastName, id)
        {
                this.testScores= Scores;
        }
        public char Calculate()
        {
                int total = 0;
            Console.WriteLine(testScores.Length);
                for (int i = 0; i < testScores.Length; i++)
                    total = total + testScores[i];
            
                int avg = Convert.ToInt32(total / testScores.Length);
                if (avg >= 90 && avg <= 100)
                    return 'O';
                if (avg >= 80 && avg < 90)
                    return 'E';
                if (avg >= 70 && avg < 80)
                    return 'A';
                if (avg >= 55 && avg < 70)
                    return 'P';
                if (avg >= 40 && avg < 55)
                    return 'D';
            
                return 'T';

        }
    }
}
