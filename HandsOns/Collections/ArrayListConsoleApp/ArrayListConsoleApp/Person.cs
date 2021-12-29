using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListConsoleApp
{
    class Person
    {
        private string name;
        private int age;
        public string ToString(string name,int age)
        {
            this.name = name;
            this.age = age;
            string details = name +"-"+age;

            return details;
        }
    }
}
