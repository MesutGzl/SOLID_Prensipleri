using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    public class BadAreaCalculator
    {
        //Alt satırdaki kodda doğru bir şekilde bir dikdörtgenin alanının hesaplanmasını yaptık.
        public static double AreaCalculate(BadRectangle badRectangle) => badRectangle.Height * badRectangle.Widht;

        //Alt satırdaki kodda bir karenin alanını hesaplamaya çalıştık fakat kalıtım aldığı sınıftaki özellikler bu sınıfa yanlış olduğu ve uymadığı için işlemin sonunda elde edeceğimiz veri yanlış olacaktır.
        public static double AreaCalculate(BadSquare badSquare) => badSquare.Height * badSquare.Widht;
    }
}
