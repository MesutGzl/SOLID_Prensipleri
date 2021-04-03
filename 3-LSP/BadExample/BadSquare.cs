using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    public class BadSquare:BadRectangle //Rectangle sınıfından kalıtım aldıp içerisindeki propertyleri override ettik.
    {
        int _height;
        public override int Height { get =>_height; set => _height = value; }

        int _widht;
        public override int Widht { get => _widht; set => _widht = value; }
    }
}
