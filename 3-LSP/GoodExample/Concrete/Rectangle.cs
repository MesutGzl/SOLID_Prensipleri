using LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.GoodExample.Concrete
{
    public class Rectangle : Shape //Shape class'ından kalıtım aldık.
    {
        public override int Edge { get; set; } //Kalıtım aldığımız sınıftan gelen property'i override ettik.
        public int Height { get; set; }//Kalıtım ettiğimiz property haricinde yapacağımı işlem için sınıfın kendisine özel bir property tanımladık.

        public int RectangleArea() => Edge * Height;//Alan hesaplamasını yaptığımız methodumuz.

    }
}
