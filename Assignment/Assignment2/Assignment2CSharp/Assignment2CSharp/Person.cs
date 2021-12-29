using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2CSharp
{
    class Person
    {
        protected string firstName;
        protected string lastname;
        protected int idNumber;

        public Person(string firstName, string lastname, int idNumber)
        {
            this.firstName = firstName;
            this.lastname = lastname;
            this.idNumber = idNumber;
        }
        public void PrintPersonData()
        {
            Console.WriteLine("Name: " + lastname + ", " + firstName + "\nID: " + idNumber);

        }
    }
}
