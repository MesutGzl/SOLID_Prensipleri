using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    public class BadRectangle //Diğer sınıflara kalıtacağımız dikdörtgen sınıfımız.
    {
        public virtual int Height { get; set; }
        public virtual int Widht { get; set; }
    }
}
