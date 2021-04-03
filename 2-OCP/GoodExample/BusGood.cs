
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample
{
    public class BusGood : VehicleGood
    {
        public override void Produce()
        {
            Console.WriteLine("Otobüs üretildi..\n"); //Baseclass'dan gelen methodu implement ettik.
        }
    }
}
