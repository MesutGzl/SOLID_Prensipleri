using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample
{
    public class TruckGood : VehicleGood
    {
        public override void Produce()
        {
            Console.WriteLine("Kamyon üretildi..\n"); //Baseclass'dan gelen methodu implement ettik.
        }
    }
}
