using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceExample20dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,opt;
            while (i != 0)
            {
                Console.WriteLine("Choose One Option:\n 1.Start car testing.\n 2.Exit");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    TestTrack.Race(new ProductionRemoteControlCar());
                    TestTrack.Race(new ExperimentalRemoteControlCar());

                    var prod = new ProductionRemoteControlCar();
                    TestTrack.Race(prod);
                    var exp = new ExperimentalRemoteControlCar();
                    TestTrack.Race(exp);

                    Console.WriteLine("Distance travelled by production car :{0}", prod.DistanceTravelled);
                    Console.WriteLine("Distance travelled by experimental car :{0}", exp.DistanceTravelled);


                    var prc1 = new ProductionRemoteControlCar();
                    var prc2 = new ProductionRemoteControlCar();

                    Random r1 = new Random();
                    int num1 = r1.Next(10);
                    int num2 = r1.Next(10);

                   
                    prc1.NumberOfVictories = num1;
                    prc2.NumberOfVictories = num2;

                    var rankings = TestTrack.GetRankedCars(prc1, prc2);

                    Console.WriteLine("Number Of Victories: " + rankings);
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Press any key to exit.");
                    break;
                }
                else
                    Console.WriteLine("Wrong Choice!");
                Console.WriteLine("_______________________________________________");
                i++;
                
            }
            Console.ReadKey();
        }
    }
}
