using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample
{
    class VehicleFactoryGood
    {
        //Artık burada switch/case ya da if/else blocklarına ihtiyacımız kalmadı. Sadece ProduceVehicle adında bir methodumuz var ve görevi abstract olan Vehicleden türetilen yeni objeyi alıp Produce() medhodunu çağırmak.
        public void ProduceVehicle(VehicleGood vehicleGood)
        {
            vehicleGood.Produce();
        }
    }
}
