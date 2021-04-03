using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample
{
    public abstract class VehicleGood
    {
        public abstract void Produce(); //Burada önceki örnekte bulunduğu class'da her eklenen araç için bulunduğu sınıfta değişiklikler yapmak zorunda kalıyorduk. Burada her kalıtım alan sınıf kendi içerisinde bu methodu barındıracak. Böylelikle yeni açılan bir class için eski bir classın içerisinde değişiklik yapmamıza gerek kalmayacak.
    }
}
