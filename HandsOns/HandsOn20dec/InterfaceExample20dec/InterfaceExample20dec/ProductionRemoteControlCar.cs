using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample20dec
{
    public class ProductionRemoteControlCar : IRemoteControlCar ,IComparable<ProductionRemoteControlCar>
    {
        public int DistanceTravelled { get; set; }
        public int NumberOfVictories { get; set; }

        public int CompareTo(ProductionRemoteControlCar other)
        {
            return this.NumberOfVictories.CompareTo(other.NumberOfVictories);
            throw new ArgumentException("Object is not a Production Car");
        }

        public void Drive()
        {
            Random r = new Random();
            int num = r.Next(10);
            DistanceTravelled = num;
        }
        

    }
}
