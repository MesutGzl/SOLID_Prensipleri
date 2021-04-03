using ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.GoodExample.Concrete
{
    public class TeamLeader : IProgrammer, ILead //TeamLeader sınıfımız geniş bir yetkiye sahip olduğundan iki farklı interface sınıfımızdan kalıtım almasını sağladık.
    {
        public string AssignProject() => "Proje Atayabilir";


        public string CreateProject() => "Proje oluşturabilir";


        public string WorkOnProject() => "Projede çalışabilir";

    }
}
