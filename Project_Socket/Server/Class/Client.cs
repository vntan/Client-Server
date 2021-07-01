using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public class ClientData
    {
        public ClientData(string iP, int port)
        {
            IP = iP;
            this.port = port;
            this.isLogin = false;
        }

        public ClientData(string iP, int port, bool isLogin)
        {
            IP = iP;
            this.port = port;
            this.isLogin = isLogin;
        }

        public string IP { get; set; }
        public int port { get; set; }
        public bool isLogin { get; set; }
    }
}
