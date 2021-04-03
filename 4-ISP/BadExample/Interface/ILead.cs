using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.BadExample.Interface
{
    interface ILead //Açtığımız bu interface'den kalıtım alacak sınıfların alacağı özellikleri belirttik.
    {
        string CreateProject();
        string AssginProject();
        string WorkOnProject();

    }
}
