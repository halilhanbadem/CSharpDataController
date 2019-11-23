using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latemERPAmateurProgrammilityOpenSource.Layers.OtherClass
{
    public class getInformationText
    {
        public string dataName { get; set; }
        public string serverName { get; set; }
        public string loginMethod { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }


        public void iniInfoRefresh()
        {
            dataName = OtherClass.iniFiles.iniRead("Database", "dataName");
            serverName = OtherClass.iniFiles.iniRead("Database", "serverName");
            loginMethod = OtherClass.iniFiles.iniRead("Database", "loginMethod");
            userName = OtherClass.iniFiles.iniRead("Database", "userName");
            userPass = OtherClass.iniFiles.iniRead("Database", "userPass");
        }
    }
}
