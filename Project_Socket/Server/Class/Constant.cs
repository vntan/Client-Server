using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Constant
    {
        private static Constant instance;
        public static Constant Instance
        {
            get { if (instance == null) instance = new Constant(); return instance; }
            private set => instance = value;
        }

        public Dictionary<string, string> listBank = new Dictionary<string, string>()
        {
            {"BIDV", "https://vapi.vnappmob.com/api/v2/exchange_rate/bid" },
            {"Sacombank (STB)", "https://vapi.vnappmob.com/api/v2/exchange_rate/stb" },
            {"Techcombank (TCB)", "https://vapi.vnappmob.com/api/v2/exchange_rate/tcb" },
            {"Vietcombank (VCB)", "https://vapi.vnappmob.com/api/v2/exchange_rate/vcb" },
            {"Vietinbank (CTG)", "https://vapi.vnappmob.com/api/v2/exchange_rate/ctg" },
            {"SBV", "https://vapi.vnappmob.com/api/v2/exchange_rate/sbv" },
        };

        public const int MaxConnect = 5;

    }
}
