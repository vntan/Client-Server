using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Exchange
    {
        public double buy_cash { get; set; }
        public double buy_transfer { get; set; }
        public string currency { get; set; }
        public double sell { get; set; }

    }

    public class ListExchange
    {
        public List<Exchange> Results { get; set; }

        public Exchange findData(string currency)
        {
            currency = currency.ToUpper();

            foreach (Exchange ex in Results)
            {
                if (ex.currency == currency) return ex;
            }

            return null;
        }
    }

}
