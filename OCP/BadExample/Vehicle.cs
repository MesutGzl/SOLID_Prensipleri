using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.BadExample
{
    public class Vehicle
    {
        public VehicleType VType { get; set; } //Kalıtım alacak sınıflara enum değerlerini atamak için bu propertyi tanımladık
    }
}
