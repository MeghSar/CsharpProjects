using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopConsoleApp
{
    class LaptopDetails:Laptop
    {
        public void ShowDetails(string nm,string pr,string prcsr, string rm,string hdd)
        {
            name = nm;
            price = pr;
            processor = prcsr;
            ram = rm;
            hard_drive = hdd;

            Console.WriteLine("__________________________");
            Console.WriteLine("Showing laptop details...\n");
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Price : ${0}", price);
            Console.WriteLine("Processor : {0}",processor );
            Console.WriteLine("RAM : {0}", ram);
            Console.WriteLine("HDD : {0}", hard_drive);
        }
    }
}
