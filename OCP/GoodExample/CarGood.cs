using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample
{
    public class CarGood : VehicleGood
    {
        public override void Produce()
        {
            Console.WriteLine("Araba üretildi..\n"); //Baseclass'dan gelen methodu implement ettik.
        }
    }
}
