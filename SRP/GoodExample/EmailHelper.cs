using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.GoodExample
{
    public class EmailHelper
    {
        //Mail gönderme methodunu User sınıfından ayrı bir sınıf içerisine alıp Single Responsibility Principle'ın "Her sınıf, methodun tek bir görevi olmalıdır." kuralına uymuş olduk.
        public void SendEmail()
        {
            //Email gönderecek method
        }
    }
}
