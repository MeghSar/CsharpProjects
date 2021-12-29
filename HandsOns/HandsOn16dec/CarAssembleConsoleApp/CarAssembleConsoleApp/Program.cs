using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rate the speed (1 to 10) : ");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Car produced per hour : {0}",AssemblyLine.CarProduced(rate));
            AssemblyLine.SuccessRate(rate);
            Console.WriteLine("Production rate per hour : {0}",AssemblyLine.ProductionRatePerHour(rate).ToString("0.00"));
            Console.WriteLine("Production rate per minute : {0}",AssemblyLine.WorkingItemPerMinute(rate));

            Console.ReadKey();
        }
    }
}
