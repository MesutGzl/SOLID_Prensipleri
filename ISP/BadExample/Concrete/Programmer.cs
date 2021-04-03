using ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.BadExample.Concrete
{
    public class Programmer : ILead
    {
        public string AssginProject() => "Programmer proje atayamaz";

        public string CreateProject() => "Programmer proje oluşturamaz";

        public string WorkOnProject() => "Projede çalışabilir";

        //Burada Interface Segregation prensibine ters düşen bir durumdayız. Alt sınıfa gereksiz yetenek, özellik kazandırdık. Bu durumu düzeltmek için ihtiyaca göre interface'ler oluşturup sadece gerekli class'ların kalıtım almasını sağlamalıyız.

    }
}
