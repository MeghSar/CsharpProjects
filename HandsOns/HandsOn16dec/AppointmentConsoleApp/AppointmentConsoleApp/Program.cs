using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i != 0 )
            {
                Console.WriteLine("Options:\n\n1.Check availability of date and time and schedule an appointment.\n2.Check Appointment is in afternoon or not.\n3.Check appointments on that date.\n4.Anniversary date\n5.Exit");
                Console.Write("\nSelect one option : ");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id == 1)
                {
                    Console.WriteLine("\nChecking The Date and Time availability...");
                    Boolean val = Appointment.HasPassed(new TakeDateTime().appointDateTime());
                    if (val == true)
                    {
                        Console.WriteLine("\nThis Date and Time is not available,enter another time.");
                        Appointment.Schedule(new TakeDateTime().appointDateTime());
                    }
                    else
                    {
                        continue;

                    }
                }
                else if (id == 2)
                {
                    Boolean b = Appointment.IsAfternoonAppointment(new TakeDateTime().appointDate());
                    if (b == true)
                    {
                        Console.WriteLine("\nAfternoon Appointment.");

                    }
                    else
                    {
                        Console.WriteLine("\nNo Afternoon Appointment.");
                    }
                }
                else if (id == 3)
                {
                    string desc = Appointment.Description(new TakeDateTime().appointDate());
                    Console.WriteLine(desc);
                }
                else if (id == 4)
                {
                    Console.WriteLine("\nAnniversary date is on {0}", Appointment.AnniversaryDate());
                }
                else if (id == 5)
                {
                    Console.WriteLine("Press any key to exit");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("\nWrong Choice!");
                    continue;
                }
                i++;
            }
            
            Console.ReadKey();
        }
    }
}
