using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentConsoleApp
{
    class TakeDateTime
    {
        
        public DateTime appointDateTime()
        {
            Console.WriteLine("Enter Date for Appointment : DD/MM/YYYY HH:MM:SS");
            var line = Console.ReadLine();
            var separate = line.Split('/',' ',':');
            int day = int.Parse(separate[0]);
            int month = int.Parse(separate[1]);
            int year = int.Parse(separate[2]);
            int hour = int.Parse(separate[3]);
            int min = int.Parse(separate[4]);
            int seconds = int.Parse(separate[5]);

            DateTime date = new DateTime(year, month, day, hour, min, seconds);
            return date;
            
        }
        public DateTime appointDate()
        {
            Console.WriteLine("Enter Date : DD/MM/YYYY");
            var line = Console.ReadLine();
            var separate = line.Split('/', ' ', ':');
            int day = int.Parse(separate[0]);
            int month = int.Parse(separate[1]);
            int year = int.Parse(separate[2]);
           
            DateTime date = new DateTime(year, month, day);
            return date;

        }
    }
}
