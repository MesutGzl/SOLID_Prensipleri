using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.BadExample
{
    public class User
    {
        //User sınıfımızda Kullanıcı adı değiştirme, Parolayı değiştirme ve mail gönderme methodlarımız bulunmakta. İlk bakışta bir sorun olduğu gözükmese de bu prensibe göre hatalı bir tasarımdır. ChangeUserName ve ChangePassword methodları User class'ının sorumlulukları olabilir fakat SendEmail methodu sorumluluğu içinde değildir. Bu durumdaki gibi bir classı sorumluluğu dışında method yığınları ile doldurmak ileride başımızı çok ağrıtacaktır. Belirli sorumluluğa ait methodları ayrı classlar içerisinde toplamak değişiklik yapacağımız methodları ve ekleyeceğimiz yeni özellikler üzerinde çalışırken zaman kaybını minimuma indirecektir.
        
        public void ChangeUserName()
        {
            //Kullanıcı adını değiştirecek method
        }

        public void ChangePassword()
        {
            //Parolayı değiştirecek method
        }

        public void SendEmail()
        {
            //Email gönderecek method
        }
    }
}
