using ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.GoodExample.Concrete
{
    public class Manager : ILead //Burada Manager sınıfımıza sadece erişebildiği görevi içeren bir interface'den kalıtım almasını sağladık.
    {
        public string AssignProject() => "Proje Atayabilir";

        public string CreateProject() => "Proje oluşturabilir";

    }
}
