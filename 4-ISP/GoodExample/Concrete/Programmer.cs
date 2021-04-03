using ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.GoodExample.Concrete
{
    public class Programmer : IProgrammer //Burada Programmer sınıfımıza sadece erişebildiği görevi içeren bir interface'den kalıtım almasını sağladık.
    {
        public string WorkOnProject() => "Projede çalışabilir";
    }
}
