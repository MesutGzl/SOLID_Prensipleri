using ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.BadExample.Concrete
{
    public class TeamLeader : ILead
    {
        public string AssginProject() => "Proje Atayabilir";


        public string CreateProject() => "Proje oluşturabilir";


        public string WorkOnProject() => "Projede çalışabilir";

    }
}
