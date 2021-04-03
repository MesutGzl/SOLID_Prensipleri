using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.BadExample
{
    public class VehicleFactory
    {
        public void ProduceVehicle(Vehicle vehicle)//Enum değerine göre ilgili aracı üreten fonksiyonları çağırdık.
        {
            switch (vehicle.VType)
            {
                case VehicleType.Car:
                    ProduceCar((Car)vehicle);
                    break;
                case VehicleType.Bus:
                    ProduceBus((Bus)vehicle);
                    break;
            }
        }

        private void ProduceCar(Car car)
        {
            Console.WriteLine("Araba üretildi.\n"); //Aldığı enum tipi Car ise burası çalışacak.
        }

        private void ProduceBus(Bus car)
        {
            Console.WriteLine("Otobüs üretildi.\n");//Aldığı enum tipi Bus ise burası çalışacak.
        }
    }
}

