using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembleConsoleApp
{
    static class AssemblyLine
    {
        static int spd1,spd2;
        static float cpr,f1,sr;
       // static double  pr;
        public static float CarProduced(int sp)
        {
            spd1 = sp;
            
            cpr = spd1 * 221;
            
            return cpr;
        }
        public static float SuccessRate(int sp)
        {
             f1 = 0.0f;
             spd2 = sp;
            if(spd2 == 0)
            {
                f1 = 0.00f;
                Console.WriteLine("{0} success rate.", f1.ToString("0.00"));
            }
            else if((spd2 >= 1) && (spd2 < 4))
            {
                f1 = 1.00f;
                Console.WriteLine("{0} success rate.", f1.ToString("0.00"));
            }
            else if((spd2 >= 5)&&(spd2<8))
            {
                f1 = 0.90f;
                Console.WriteLine("{0} success rate.", f1.ToString("0.00"));
            }
            else if(spd2 == 9)
            {
                f1 = 0.80f;
                Console.WriteLine("{0} success rate.", f1.ToString("0.00"));
            }
            else
            {
                f1 = 0.77f;
                Console.WriteLine("{0} success rate.", f1.ToString("0.00"));
            }
            
            return f1;
        }
        public static float ProductionRatePerHour(int p)
        {
            
            int p1 = p;
           float sr = p1 * f1 * 221;
            return sr;
        }
        public static int WorkingItemPerMinute(int w)
        {
            int w1 = w;
            int wpr = Convert.ToInt32(CarProduced(w1) / 60);
            return wpr;
        }

    }
}

