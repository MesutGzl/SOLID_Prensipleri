using LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.GoodExample.Concrete
{
    public class Square : Shape //Shape class'ından kalıtım aldık.
    {
        public override int Edge { get; set; }//Kalıtım aldığımız sınıftan gelen property'i override ettik.



        public int SquareArea() => Edge * Edge; //Alan hesaplamasını yaptığımız methodumuz

        
    }
}
